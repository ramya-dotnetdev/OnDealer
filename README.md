 # DealerOn
Coding exercise for a mars rover problem.

A simple two-dimensional coordinate grid is mapped to the plateau to aid in rover navigation. Each point on the grid is
represented by a pair of numbers X Y which correspond to the number of points East or North, respectively, from the
origin. The origin of the grid is represented by 0 0 which corresponds to the southwest corner of the plateau. 0 1 is
the point directly north of 0 0, 1 1 is the point immediately east of 0 1, etc. A rover’s current position and heading are
represented by a triple X Y Z consisting of its current grid position X Y plus a letter Z corresponding to one of the four
cardinal compass points, N E S W. For example, 0 0 N indicates that the rover is in the very southwest corner of the
plateau, facing north.

NASA remotely controls rovers via instructions consisting of strings of letters. Possible instruction letters are L, R,
and M. L and R instruct the rover to turn 90 degrees left or right, respectively (without moving from its current spot),
while M instructs the rover to move forward one grid point along its current heading.

Solution:

For each rover: Based on the initial position of the rover, take a character from the instruction and if it's L or R change the direction
of Rover. If the instruction is Move, increse or decrease the position value.