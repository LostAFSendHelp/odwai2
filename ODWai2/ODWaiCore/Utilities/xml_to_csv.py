import os
import glob
import pandas as pd
import sys
import getopt as options
import xml.etree.ElementTree as ET
from pathlib import Path


def xml_to_csv(path):
    xml_list = []
    for xml_file in glob.glob(path + '/*.xml'):
        tree = ET.parse(xml_file)
        root = tree.getroot()
        for member in root.findall('object'):
            value = (root.find('filename').text,
                     int(root.find('size')[0].text),
                     int(root.find('size')[1].text),
                     member[0].text,
                     int(member[4][0].text),
                     int(member[4][1].text),
                     int(member[4][2].text),
                     int(member[4][3].text)
                     )
            xml_list.append(value)
    column_name = ['filename', 'width', 'height', 'class', 'xmin', 'ymin', 'xmax', 'ymax']
    xml_df = pd.DataFrame(xml_list, columns=column_name)
    return xml_df


def convert(argv):
    try:
        opts, args = options.getopt(argv, "p:", ["path="])
    except options.GetoptError as error:
        sys.exit(99)
    path = ""

    for opt, arg in opts:
        if opt in ("-p", "--path"):
            path = arg

    if len(path) == 0:
        sys.exit(98)

    for folder in ['train','test']:
        image_path = path + "/" + folder
        xml_df = xml_to_csv(image_path)
        save_path = path + "/Training resources"
        Path(save_path).mkdir(parents=True, exist_ok=True)
        xml_df.to_csv((save_path + "/" + folder + '_labels.csv'), index=None)
    sys.exit(0)

if __name__ == "__main__":
    convert(sys.argv[1:])
