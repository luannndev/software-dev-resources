
import tkinter as tk
from tkinter import messagebox

def on_button_click():
    messagebox.showinfo("Example App", "Button clicked!")

root = tk.Tk()
root.title("Example Tkinter App")

button = tk.Button(root, text="Click me!", command=on_button_click)
button.pack(pady=20)

root.mainloop()
