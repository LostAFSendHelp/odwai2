# 
# Simulator called my master class, simulates simple user inputs on textboxes and buttons
# 

import pyautogui as pg
import getopt as options
import sys
import json

FULL_NAME = ["full name", "fullname", "name", "your name"]
FIRST_NAME = ["first name", "first", "firstname", "your first name", "your firstname"]
LAST_NAME = ["last name", "lastname", "surname", "your last name", "your lastname"]
PHONE = ["phone", "telephone", "mobile", "number", "phone number", "tel", "mobile number", "cell phone", "your phone number"]
EMAIL = ["email", "e-mail", "e mail", "gmail", "g-mail", "g mail", "mail", "email address", "username", "your email address"]
WEBSITE = ["website", "web", "web address", "your website", "your web address"]
PASSWORD = ["password", "confirm password", "pass", "re-enter password", "enter password", "enter password again"]

pg.FAILSAFE = False
text_input = {
    "name": "Team 17 Duy Tan",
    "email": "team17@team17.duytan.edu",
    "phone": "+9999999999",
    "firstname": "Team 17",
    "lastname": "Duy Tan",
    "password": "123456789Aa",
    "website": "https://team17.duytan.edu.com/chacocaigi"
}

def get_results(argv):
    print("start")
    try:
        opts, args = options.getopt(argv, "r:", ["result-path="])
    except options.GetoptError as error:
        print(69)
        sys.exit(69)
    
    path = ""

    for opt, arg in opts:
        if opt in ("-r", "--result-path"):
            path = arg
    
    if len(path) == 0:
        print(68)
        sys.exit(68)
    
    with open(path) as result_file:
        boxes = []
        results = json.load(result_file)
        for result in results:
            if result["class_name"] == "tb":
                boxes.append(result)
        return boxes

def tb_simulator(textboxes):
    for idx, tb in enumerate(textboxes):
        pg.moveTo(tb["center_x"], tb["center_y"], duration = .25)
        pg.click(button = "left", clicks = 1)
        pg.click(button = "left", clicks = 2)
        match_input(tb["text"])
    
    textboxes.clear()

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
    boxes = get_results(sys.argv[1:])
    tb_simulator(boxes)
    sys.exit(0)