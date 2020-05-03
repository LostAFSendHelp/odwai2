# 
# Simulator called my master class, simulates simple user inputs on textboxes and buttons
# 

import pyautogui as pg
import getopt as options
import sys
import json
import time

FULL_NAME = ["full name", "fullname", "name", "your name"]
FIRST_NAME = ["first name", "first", "firstname", "your first name", "your firstname"]
LAST_NAME = ["last name", "lastname", "surname", "your last name", "your lastname"]
PHONE = ["phone", "telephone", "mobile", "number", "phone number", "tel", "mobile number", "cell phone", "your phone number"]
EMAIL = ["email", "e-mail", "e mail", "gmail", "g-mail", "g mail", "mail", "email address", "username", "your email address"]
WEBSITE = ["website", "web", "web address", "your website", "your web address"]
PASSWORD = ["password", "confirm password", "pass", "re-enter password", "enter password", "enter password again"]

RESULT_PATH = "../../temp result/temp.json"
TEST_CASE_PATH = "../../temp result/testcases/testcases.json"

pg.FAILSAFE = False
text_input = {
    "name": "default Team 17 Duy Tan",
    "email": "default team17@team17.duytan.edu",
    "phone": "+9999999999",
    "firstname": "default Team 17",
    "lastname": "default Duy Tan",
    "password": "default123456789Aa",
    "website": "default https://team17.duytan.edu.com/chacocaigi"
}

def get_results():
    boxes = []
    with open(RESULT_PATH) as result_file:
        results = json.load(result_file)
        for result in results:
            if result["class_name"] == "tb":
                boxes.append(result)
        result_file.close()
    return boxes

def get_test_cases():
    tests = []
    with open(TEST_CASE_PATH) as testcases_file:
        fields = json.load(testcases_file)
        for field in fields:
            test = {
                "field_name": field["field_name"],
                "associated": map(lambda x: x.lower(), field["associated"]),
                "error": field["error_forces"] + field["error_rejects"],
                "valid": field["valid"]
            }
            tests.append(test)
        testcases_file.close()
    return tests

def classify_boxes(boxes, fields):
    unrecognized = []
    recognized = []
    for box in boxes:
        for field in fields:
            if box["text"] != "" and box["text"] in field["associated"]:
                rec = {
                    "field_name": field["field_name"],
                    "center_x": box["center_x"],
                    "center_y": box["center_y"],
                    "error": field["error"],
                    "valid": field["valid"]
                }
                recognized.append(rec)
                break
        unrecognized.append(box)
    return(recognized, unrecognized)

def simulate_recognized(boxes):
    "Simulate inputs on recognized field"
    # TODO: check for simulation option (error/valid/etc)
    
    # simulate errors
    for box in boxes:
        for error in box["error"]:
            simulate_error(box, error, boxes)
            time.sleep(2.5)

    # simulate lower valids
    for box in boxes:
        input_text_at(box["valid"]["Item1"], box)
    
    time.sleep(2.5)

    # simulate upper valids
    for box in boxes:
        input_text_at(box["valid"]["Item2"], box)

def simulate_error(error_box, error, boxes):
    "Simulate error inputs: error for specified field, valid for the rest"
    
    for box in boxes:
        if box["field_name"] == error_box["field_name"]:
            input_text_at(error, box)
        else:
            input_text_at(box["valid"]["Item2"], box)

def input_text_at(text, box):
    pg.moveTo(box["center_x"], box["center_y"], duration = .1)
    pg.click(button = "left", clicks = 1)
    pg.click(button = "left", clicks = 2)
    pg.typewrite(text)

def simulate_unrecognized(boxes):
    for idx, tb in enumerate(boxes):
        pg.moveTo(tb["center_x"], tb["center_y"], duration = .25)
        pg.click(button = "left", clicks = 1)
        pg.click(button = "left", clicks = 2)
        match_input(tb["text"])

def btn_simulator(buttons):
    for btn in buttons:
        pg.moveTo(btn["x"], btn["y"], duration = .25)
        pg.click(button = "left", clicks = 1)
        break

    buttons.clear()

def match(text):
    if "@" in text or text in EMAIL:
        return text_input["email"]
    if "your full" in text or text in FULL_NAME:
        return text_input["name"]
    if text in FIRST_NAME:
        return text_input["firstname"]
    if text in LAST_NAME:
        return text_input["lastname"]
    if "phone" in text or text in PHONE:
        return text_input["phone"]
    if text in EMAIL:
        return text_input["email"]
    if text in PHONE:
        return text_input["password"]
    if "site" in text or text in WEBSITE:
        return text_input["website"]
    return "defaultinput"

def match_input(text):
    pg.typewrite(match(text))

if __name__ == "__main__":
    boxes = get_results()
    simulate_unrecognized(boxes)
    sys.exit(0)