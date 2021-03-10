Console Application<br>
Exercise: Multidimensional Arrays
# Miner
  We get as input the __size__ of the __field__ in which our miner moves. The field is __always a square__. After that we will receive the commands which represent the directions in which the miner should move. The miner __starts__ from position – '__s__'. The commands will be: __left__, __right__, __up__ and __down__. If the miner has reached a side edge of the field and the next command indicates that they have to get out of the field, they must __remain on their current possition and ignore the current command__. The possible characters that may appear on the screen are:
- __\*__ – a regular position on the field.
- __e__ – the end of the route. 
- __c__  - coal
- __s__ - the place where the __miner starts__<br>
  Each time when the miner finds a coal, they collects it and __replace it with '\*'__. Keep track of the __count of the collected coals__. If the miner collects all of the coals in the field, the program stops and you have to print the following message: "__You collected all coals! ({rowIndex}, {colIndex})__".<br><br>
  If the miner __steps at 'e' the game is over (the program stops)__ and you have to print the following message: "__Game over! ({rowIndex}, {colIndex})__".<br><br>
  If there are no more commands and none of the above cases had happened, you have to print the following message: "__{remainingCoals} coals left. ({rowIndex}, {colIndex})__".
## Input
- __Field size__ – an integer number.
- __Commands to move__ the miner – an array of strings separated by whitespace.
- __The field: some of the following characters (\*, e, c, s)__, separated by whitespace.
## Output
- There are three types of output:
    - If all the coals have been collected, print the following output: "__You collected all coals! ({rowIndex}, {colIndex})__"
    - If you have reached the end, you have to stop moving and print the following line: "__Game over! ({rowIndex}, {colIndex})__"
    - If there are no more commands and none of the above cases had happened, you have to print the following message: "__{totalCoals} coals left. ({rowIndex}, {colIndex})__"
## Constraints
- The __field size__ will be a 32-bit integer in the range [0 … 2 147 483 647].
- The field will always have only one’s’.
- Allowed working time for your program: 0.1 seconds.
- Allowed memory: 16 MB.
## Examples
Input|Output
-----|------
5<br>up right right up right<br>* * * c *<br>* * * e *<br>* * c * *<br>s * * c *<br>* * c * *|Game over! (1, 3)
4<br>up right right right down<br>* * * e<br>* * c *<br>* s * c<br>* * * *|You collected all coals! (2, 3)
6<br>left left down right up left left down down down<br>* * * * * *<br>e * * * c *<br>* * c s * *<br>* * * * * *<br>c * * * c *<br>* * c * * *|3	coals left. (5, 0)
