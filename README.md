# RobotWarsApp
FA Interview Task.

Fist of all I like to say this was a fun test and I enjoyed doing it.
The code works well and meets the requirement.
However I believe I misunderstood one part of your question.
This is on the coordination.The paper stats that the start point of the arena is (y0,x0) left hand corner.
So when you set the arena to the test example of 7 6 that's (y0-6,x0-5)
The start position of the robot is 2 4 E and the instruction sent to it is MMRMMRMRRM.
This translates as MM(S)MM(W)M(N)(E)M This leads the Robot to crash after it is on the position 2 5 E after the second instruction M is executed.
Maybe we can talk about this on the interview. But the code works well.
