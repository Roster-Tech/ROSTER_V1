import shutil
import os
import speech_recognition as sr
import pyttsx3

name = ""

def speak(audioString):
    print(audioString)
    engine = pyttsx3.init()
    engine.say(audioString)
    engine.runAndWait()

def recordAudio():
    # Record Audio
    r = sr.Recognizer()
    with sr.Microphone() as source:
        audio = r.listen(source,phrase_time_limit = 3)

    # Speech recognition using Google Speech Recognition
    data = ""
    try:
        # Uses the default API key
        # To use another API key: `r.recognize_google(audio, key="GOOGLE_SPEECH_RECOGNITION_API_KEY")`
        data = r.recognize_google(audio)
        print(data)
    except sr.UnknownValueError:
        speak("Roster Recognition could not understand audio")
    except sr.RequestError as e:
        speak("Could not request results from Roster Recognition service; {0}".format(e))

    return data

def Delete():
    speak("Enter the path of file for deletion")
    path = input()
    if os.path.exists(path):
        speak("File Found")
        os.remove(path)
        speak("File has been deleted")
    else:
        speak("File Does not exist")



def Dirlist():
    speak("Enter the Directory path to display")
    path=input()
    try:
        sortlist=sorted(os.listdir(path))
        i=0
        while(i<len(sortlist)):
            print(sortlist[i])
            i+=1
        speak("folder items are displayed above")
    except:
        speak("cannot display the content")

def Check(fp):

    if fp==1:
        speak("Enter the file path")
        path=input()
        os.path.isfile(path)
    if os.path.isfile(path)==True:
        speak("File Found")
    else:
        speak("File not found")
    if fp==2:
        speak("Enter the directory path")
        path=input()
        os.path.isdir(path)
    if os.path.isdir(path)==False:
        speak("Directory Found")
    else:
        speak("Directory Not Found")


def Move():
    speak("Enter the source path of file or folder to move")
    path1=input()
    speak("Enter the destination path to move")
    path2=input()
    try:
        shutil.move(path1,path2)
        speak("File moved")
    except:
        speak("cannot move the file")
        
def Copy():
    speak("Enter the source path of file or folder to copy")
    path1=input()
    speak("Enter the destination path to copy")
    path2=input()
    try:
        shutil.copy(path1,path2)
        speak("Copied")
    except:
        speak("cannot copy")        


def Makedir():
    speak("Enter the directory name with path to make new directory")
    path=input()
    try:
        os.makedirs(path)
        speak("Directory Created")
    except:
        speak("cannot create the directory")


def Removedir():
    speak("Enter the path of Directory")
    path=input()
    try:
        os.rmdir(path)
        speak("Directory removed")
    except:
        speak("cannot remove the directory")

def Openfile():
    speak("Please enter the file path")
    path=input()
    try:
        os.system("start "+path)
        speak("File is openning")
    except:
        speak("File not found")

def Openfolder():
    speak("Please enter the folder path")
    path=input()
    try:
        os.system("start "+path)
        speak("File is openning")
    except:
        speak("File not found")


def roster(data):
    if "how are you" in data:
        speak("I am fine")
        return 0
    elif "no" in data:
        speak("Okay! Goodbye " + name)
        return 2
    elif "open a file" in data:
        Openfile()
        return 0
    elif "open a folder" in data:
        Openfolder()
        return 0
    elif "delete a file" in data:
        Delete()
        return 0
    elif "list files" in data:
        Dirlist()
        return 0
    elif "check a file" in data:
        Check(1)
        return 0
    elif "check a folder" in data:
        Check(2)
        return 0
    elif "create a folder" in data:
        Removedir()
        return 0
    elif "delete a folder" in data:
        Makedir()
        return 0
    elif "move" in data:
        Move()
        return 0
    elif "copy" in data:
        Copy()
        return 0
    else:
        return 1


speak("Hello there. My name is Roster.")
speak("I will help you in managing your files.")
speak("Can I know your name")
while 1:
    name = recordAudio()
    if name == "":
        speak("Please try again")
    else:
        break

speak("Hi "+name+" what can I do for you?")
while 1:
    data = recordAudio()
    fail = roster(data)
    if fail == 1:
        speak("Please try again " + name)
    elif fail == 2:
        break
    else :
        speak("Anything else " + name + " ?")
