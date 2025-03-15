/*Implicit Conversion is a way in which we can Convert a variable from one data type to another
as long as the byte size of the new variable datatype is more than the old variable datatype

for ex:

int can be converted into a double or a long
*/

int myInt = 10;
long myLong = myInt;//myInt can be assigned to myLong because long holds more bytes and bits than int
System.Console.WriteLine($"Integer after being converted to long is {myLong}");