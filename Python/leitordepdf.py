import PyPDF2
import pyttsx3
import pdfplumber

file = 'Plano.pdf'

pdfFlieObj = open(file, 'rb')
pdfReader = PyPDF2.PdfFileReader(pdfFlieObj)
pages = pdfReader.numPages

with pdfplumber.open(file) as pdf:
    for i in range(0, pages):
        page = pdf.pages[i]
        text = page.extract_text()
        print(text)
        speaker = pyttsx3.init()
        speaker.say(text)
        speaker.runAndWait()
