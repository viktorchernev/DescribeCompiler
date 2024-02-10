## Describe - Slash Notation

Slash notation was the first addressing scheme used in the prototype of the describe language. It is no longer in use, and may or may not be returned to future versions of the language. The idea behind slash notation is to simply put the file name in the id of items that are in other files, using forward slashes as separators. However, there are a number of cons to this approach:<br>

 • produces long tag ids<br>
 • cross referencing requires implementation of ```../../``` up path<br>
 • very fragile - renaming or rearranging of files breaks lists<br>
 • not well suited for database integration<br>


### Links
[Next - File Names](./File-Names.md)<br>
[Prev - Dot Notation](./Dot-Notation.md)<br>
[Back](../Home.md)