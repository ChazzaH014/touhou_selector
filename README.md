# Touhou Game Selector

I have created this application as i am working on making an arcade cabinet for Touhou Project. I wanted a way to be able to launch the games using just the cabinet buttons. 
(Keyboard and mouse will only be needed for the initial setup). I thought it would be nice to share it with the public. The code is a bit dirty but it works and i plan on optimizing the code in future.

# How to use
This is the selection screen. It is pretty basic, bear in mind that this is the first version. The controls are displayed on the screen. It is pretty straight forward to use.

- `Down Arrow` to increment. 
- `Up Arrow` to decrement. 
- `Z` to Launch the selected game. 
- `X` to exit. 

In the future i may implement custom keybinds. 
You will not be able to launch anything until you configure the directories, so lets take a look at the configuration page.

![image](https://github.com/user-attachments/assets/d609a398-fda5-45f8-826b-69b8ec1a6142)

This is the configuration page. You can get here by pressing `ALT + C` Here you can set the location of your games. 
- After publishing my first pre-release, **I have discovered a new method that will only require users to select just the exe**, and i will be implementing this in the next release. (The working directory has to be specified when opening the games otherwise it throws an error.)

On this page you need to select your games and hit save. **Your changes will be kept.**

![image](https://github.com/user-attachments/assets/c95c0a5e-606e-4d26-8836-bfbdf005c15b)

Now it's ready to go.
