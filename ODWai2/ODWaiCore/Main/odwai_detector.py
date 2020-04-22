######## Image Object Detection Using Tensorflow-trained Classifier #########
#
# Author: Evan Juras
# Editor: Nguyen Chuong
# Date: 1/10/19
# Description: 
# This is the object detector of the ODWai system

## Some of the code is copied from Google's example at
## https://github.com/tensorflow/models/blob/master/research/object_detection/object_detection_tutorial.ipynb

## and some is copied from Dat Tran's example at
## https://github.com/datitran/object_detector_app/blob/master/object_detection_app.py

## but I changed it to make it more understandable to me.

# Import packages
import os
import cv2
import numpy as np
import tensorflow as tf
import sys
import mss
import pytesseract as pt
import json

# Import utilites
from utils import label_map_util
from utils import visualization_utils as vis_util

from PIL import Image
from pathlib import Path

# Arguments
flags = tf.app.flags
flags.DEFINE_string('graph_path', '', 'Path to the inference graph')
flags.DEFINE_string('root_x', '', 'X of the frame\'s top left corner')
flags.DEFINE_string('root_y', '', 'Y of the frame\'s top left corner')
flags.DEFINE_string('width', '', 'Width of the frame')
flags.DEFINE_string('height', '', 'Height of the frame')
flags.DEFINE_string('labelmap', '', 'path to the label map')
FLAGS = flags.FLAGS

# Path to frozen detection graph .pb file, which contains the model that is used
# for object detection.
PATH_TO_GRAPH = FLAGS.graph_path

# Path to label map file
PATH_TO_LABELS = FLAGS.labelmap

# Number of classes the object detector can identify
NUM_CLASSES = 4

TEMP_PATH = "../../temp result"

OUTER_THRESHOLD = .80
INNTER_THRESHOLD = .90

# Load the label map.
# Label maps map indices to category names, so that when our convolution
# network predicts `5`, we know that this corresponds to `king`.
# Here we use internal utility functions, but anything that returns a
# dictionary mapping integers to appropriate string labels would be fine
label_map = label_map_util.load_labelmap(PATH_TO_LABELS)
categories = label_map_util.convert_label_map_to_categories(label_map, max_num_classes=NUM_CLASSES, use_display_name=True)
category_index = label_map_util.create_category_index(categories)

class Detect_img():

    def __init__(self):
        self.objects = []

        self.root = {"x": 0, "y": 0}

    def __check_overlap(self, info):
        overlapped = False
        
        for object in self.objects:
            if (info["root_x"] > object["root_x"] and info["root_x"] < object["root_x"] + object["width"]
            and info["root_y"] > object["root_y"] and info["root_y"] < object["root_y"] + object["height"]):
                overlapped = True
                break
        
        return overlapped

    def capture_n_detect( self, top, left, width, height, skip_check ):
        os.system('cls')
        
        # reset object collection
        self.objects = []

        # Load the Tensorflow model into memory.
        detection_graph = tf.Graph()
        with detection_graph.as_default():
            od_graph_def = tf.GraphDef()
            with tf.gfile.GFile(PATH_TO_GRAPH, 'rb') as fid:
                serialized_graph = fid.read()
                od_graph_def.ParseFromString(serialized_graph)
                tf.import_graph_def(od_graph_def, name='')

            sess = tf.Session(graph=detection_graph)

        # Define input and output tensors (i.e. data) for the object detection classifier

        # Input tensor is the image
        image_tensor = detection_graph.get_tensor_by_name('image_tensor:0')

        # Output tensors are the detection boxes, scores, and classes
        # Each box represents a part of the image where a particular object was detected
        detection_boxes = detection_graph.get_tensor_by_name('detection_boxes:0')

        # Each score represents level of confidence for each of the objects.
        # The score is shown on the result image, together with the class label.
        detection_scores = detection_graph.get_tensor_by_name('detection_scores:0')
        detection_classes = detection_graph.get_tensor_by_name('detection_classes:0')

        # Number of objects detected
        num_detections = detection_graph.get_tensor_by_name('num_detections:0')

        # Load image using OpenCV and
        # expand image dimensions to have shape: [1, None, None, 3]
        # i.e. a single-column array, where each item in the column has the pixel RGB value

        sct = mss.mss()
        scrn = {"top": top, "left": left, "width": width, "height": height}
		
        sct_img = sct.grab(scrn)
        img = Image.frombytes("RGB", sct_img.size, sct_img.bgra, "raw", "BGRX")
        save_path = os.path.abspath(TEMP_PATH)
        Path(save_path).mkdir(parents=True, exist_ok=True)
        img.save(save_path + "/temp.png")

        frame = cv2.cvtColor(np.array(sct_img), cv2.COLOR_BGRA2BGR)
        frame_expanded = np.expand_dims(frame, axis=0)

        # Perform the actual detection by running the model with the image as input
        (boxes, scores, classes, num) = sess.run(
            [detection_boxes, detection_scores, detection_classes, num_detections],
            feed_dict={image_tensor: frame_expanded})

        # Draw the results of the detection (aka 'visulaize the results')
        vis_util.visualize_boxes_and_labels_on_image_array(
            frame,
            np.squeeze(boxes),
            np.squeeze(classes).astype(np.int32),
            np.squeeze(scores),
            category_index,
            use_normalized_coordinates=True,
            line_thickness=8,
            min_score_thresh=0.80)

        for idx, box in enumerate(boxes[0]):

            if scores[0][idx] >= OUTER_THRESHOLD:
                ymin = box[0] * height
                xmin = box[1] * width
                ymax = box[2] * height
                xmax = box[3] * width
                class_name = "Unknown"
                bias = "NA"
                inner_text = "NA"
                
                if scores[0][idx] < INNTER_THRESHOLD:
                    bias = category_index[classes[0][idx]]["name"]
                else:
                    class_name = category_index[classes[0][idx]]["name"]
                    local_height = int(ymax - ymin)
                    local_width = int(xmax - xmin)
                    if class_name in ("tb", "btn"):                        
                        # corner coordinates and sizes of textboxes/buttons on the screen
                        local_top = int(top + ymin)
                        local_left = int(left + xmin)

                        # grab screen within textboxes/buttons
                        local_scrn = {"top": local_top, "left": local_left, "width": local_width, "height": local_height}
                        local_frame = np.array(sct.grab(local_scrn), dtype=np.uint8)
                        local_frame = np.flip(local_frame[:, :, :3], 2)
                        
                        # identify texts and append to output
                        inner_text = pt.image_to_string(local_frame)

                    # center coordinates for simulation
                    center_x = int(left + (xmin + xmax)/2)
                    center_y = int(top + (ymin + ymax)/2)
                    info = {
                        "class_name": class_name,
                        "bias": bias,
                        "center_x": center_x, 
                        "center_y": center_y,
                        "root_x": xmin,
                        "root_y": ymin,
                        "width": local_width,
                        "height": local_height,
                        "text": inner_text.lower(),
                    }

                    if (self.__check_overlap(info) == False):
                        self.objects.append(info)
        with open(TEMP_PATH + "/temp.json", "w", encoding="utf-8") as output_file:
            json.dump(self.objects, output_file, ensure_ascii=True, indent=4)

if __name__ == "__main__":
    detector = Detect_img()
    detector.capture_n_detect(int(FLAGS.root_y), int(FLAGS.root_x), int(FLAGS.width), int(FLAGS.height), False) # root_y first because it equals top