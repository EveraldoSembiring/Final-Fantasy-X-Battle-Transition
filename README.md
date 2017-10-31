Final Fantasy X is most memorable FF for me. So I try to remake the battle transition just for fun.

The app will take the pixel of the screen and using it to create a texture which will be the glass texture.
This system using pre made shattered cube for the glass object and using standard specular material for the glossiness.
All glass pieces has rigidbody but set not active at start.
When rigidbody created, torque and velocity of rigidbody increased gradually each frame but not applied because the rigidbody is not active.
The rigidbodies will be activated when hit a collider which moving from right to left so the glass that start moving first is on the most right and the last is the most left.

preview : https://youtu.be/LbieVhZopuc