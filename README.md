# in-class-activities
## Devlogs
### W1
Write your W1 activity Devlog here.



### W2
Create future Devlog sub-headers with the three # symbols, then write your Devlogs below them.

1 Why are the r, g, and b variables floats instead of ints, bools, or strings?

In this project, we used 0-1 to manipulate rgb values. Float is optimized to manipulate the number between 0 to 1.

int --> they cannot manipulate decimals
bools --> they are for true/false value
strings --> they are for characters

2 Why is the _bounce variable an int instead of a float, bool, or string?

it's because _bounce represents the count of how many times the ball bounced in the game. The count of ball's bounce cannot be shown in float (decimals). Also, it's not true/false value, so boolean cannot be used too. String is used to show the characters, not the integer numbers. (it can be used to show numbers, but in characters)

3 The error you got after Step 4 of Part 2 told you something useful about why that line of code was broken- what was it?

it missed semicolon --> easy to catch :D


### W3

Table 2: rhythm game

The return type should be boolean and the parameter should be float.
The time when the player hit a beat should be stored in float variable, which can interpret time accurately.
The return type should be boolean to show whether or not the player hit the beat correctly.

If the game should show up several messages (like good, perfect, miss), then the return type should be string to show the text messages on the screen.

Monobehavior coding activity:

Class is like a huge category, and components are like the items under the category. For example, if the category is book, then components should include titles of books.

I think the ball gets too bright due to the multiplication applied in the code.


### W4

#2

Tables 1-10: lines 5, 22, and 25
- line 5: it declares the flaot variable called _moveSpeed, which is accessible in Inspector screen. (it also has the value of 1.0f)
- line 22: it creates new float variable called translation, which calculates the vertical moving speed.
- line 25: it translates the moving speed from "translation" variable to make the cat component move in the scene.

Tables 11-19: lines 17, 28, and 32


### W5

How can I apply vectors when the game is combined with 2D objects and 3D objects?

What’s the key difference between vectors and transformations?
Vector is the concept for directions and magnitude and transformation (attached to the game object) is the actual thing to change movements of game objects in Unity.

Transform.translate()?
Position and location of game object → move it

All codes in the assignment must be in the lecture materials covered during the class
Review is important to catch up lecture contents and codings



What member variable(s) does this class need?
- transform & navmesh is required to make the deer move toward target in the game

What method(s) does this class need? Should it be something that Unity provides (like Start(), Update(), or a collision method), or one you write?
- update method is required

What should the method(s) do?
- update method will be used to control deer's movement in the game (in thsi case the deer will go toward mushroom)




## Open-Source Assets
### W1
- Animals: https://assetstore.unity.com/packages/3d/characters/animals/animals-free-animated-low-poly-3d-models-260727 
- Low-poly environment: https://assetstore.unity.com/packages/3d/environments/landscapes/low-poly-simple-nature-pack-162153 