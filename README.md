# CG_FinalExam
# Jelani Garnes - 100801696 - Even
## General Details
### Controls
Player Movement - WASD</br>
Lava Intensity Toggles - 1 to increase & 2 to decrease</br>
Bloom Toggles - 3 for bloom highlight enemy  & 4 normal toon enemy</br>

### Shaders
#### Normal Map - Walls
For the normal map shader on the walls and platform ground is creates an illusion of surface details by altering the surface normal using a normal map texture. Which encodes the direction of the surface normal in rgb color values.</br>
Or rather it uses a texture to store information about how to modify the surface normals across the model. The bright cyan areas in the normal map texture show a steep modification to the polygon’s surface normal.</br>
![wallpaper](https://user-images.githubusercontent.com/35810049/233708633-fba2c1c9-9fec-49e9-8c98-1973ce42453a.png)

</br>


#### Lava
In the scene the lava surrounds the play area with intention to be a player boundary for movement affecting the players health if touched but isn't fully functional.</br>
![lava](https://user-images.githubusercontent.com/35810049/233708668-99b9efe9-5762-4f08-825b-01db845f60b3.png)

![water](https://user-images.githubusercontent.com/35810049/233706242-cf35904b-9de0-47d3-9441-c1a59d5f43ab.png)

#### Bloom
In the scene the bloom was used to highlight the ball enemy and cause it to glow with the black streaks</br>
This was implemented in the shader by declaring 4 properties which are the texture, bloom threshold, flash speed and flash amplitude. In the surface function I then sample the base texture, calculate the brightness of the pixel, calculate the bloom threshold value,used a sine wave calculation which defines a variable setting its value to the current time multiplied by the flashspeed, calculate the sine of the variable and store the results in the sine variable, then calculate the the flashIntensity as the maximum of 0 and the product of the sine and FlashAmplitude parameters. Following this apply the bloom effect based on the brightness of the pixel, adjust the bloom intensity as needed through the emission and subtract the bloom color from the base color.</br>
![enemy1](https://user-images.githubusercontent.com/35810049/233708716-47d72b05-8600-44f4-86fe-c410c0148e44.png)


#### Extra Shader - Outline with bump mapping
This was added to the big cube enemy which if the player collides with can cause the player to fall and well die, game over</br>
This was implemented through the following:</br>
![extra](https://user-images.githubusercontent.com/35810049/233707455-54eb2b27-db59-46a8-bc93-98146f9f41f4.png)
![enemy2](https://user-images.githubusercontent.com/35810049/233708794-722e0c58-07db-45c7-82bd-4c6dd5d4bebb.png)

</br>
Additionally the player has a toonramp shader applied to its material for a cartoon green effect. </br>
![player](https://user-images.githubusercontent.com/35810049/233709315-cc73f057-f89c-49f0-a4be-6251e87380c2.png)



### Project Build
https://github.com/Jelanigarnes/CG_FinalExam/releases/tag/build

