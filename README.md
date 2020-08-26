This Project is in Initial stage of development

# ROSTER_V1
A terminal based python script for managing files and folders over voice command.

## Requirements

[Python 3.6](https://www.python.org/downloads/)</br>
[SpeechRecognition](https://pypi.org/project/SpeechRecognition/)</br>
[pyttsx3](https://pypi.org/project/pyttsx3/) </br>
**Note** : Also install the required dependencies of the above packages. 

## Getting started
```bash
git clone https://github.com/Roster-Tech/ROSTER_V1.git
cd ROSTER_V1
python roster.py
```

## Basic functions

As the script starts running, roster will ask for your name.
Then it will ask you for the action that needs to be done. </br>
You can say :</br>
**"how are you" - It will reply "I am fine". </br>
"no" - will stop the script with the message "Okay! Goodbye ". </br>
"open a file" - It will ask for the file path and will open the file if it exits. </br>
"open a folder" - It will ask for the folder path and will open the folder if it exits. </br>
"delete a file" - It will ask for the file path and will delete the file if it exits. </br>
"delete a folder" - It will ask for the folder path and will delete the file if it exits. </br>
"create a folder" - It will ask for a path and if that path is valid it will create a folder in it. </br>
"list files"  - It will ask for a path and if that path is valid it will list all the files and subfolders in that path. </br>
"check a file" - It will ask for a path and if that path is valid will reply affirmative. </br>
"check a folder" - It will ask for a path and if that path is valid will reply affirmative. </br> 
"move" - It will ask for the source and destination path and if both are valid will perform the move function. </br>**

If a action is succesful it will ask if anything else the user will like to do. User can reply **no** and the script will stop. </br>
If roster couldn't get any audio or anything that it couldn't understand it will alert the user after every **3 seconds**.

## Authors

* **Rajat Ghoshal** - [rghoshal18](https://github.com/rghoshal18)
* **Rohit Chauhan** - [rchouhan170590](https://github.com/rchouhan170590)


## License

This project is open source.
