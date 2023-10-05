# KataStringCalculator
String calculator is a program to sum lists of numbers

# Instalation
In visual studio publish the String claculator project to the the executable

# Usage
In the commnad line you execute String calculator.exe followed by a string of numbers as specified below:
```bash
# The default separator is a comma
StringCalculator.exe "1,2,3,4,5,6"

# You can olso include line jumps as separators
StringCalculator.exe "1\n2,3,4,5,6"

#if you want to specify a new separator it will have to be preceded by //
StringCalculator.exe "//;1;2;3;4;5;6"

#if negative numbers are included it will fail as they are not allowed
StringCalculator.exe "1,-2,3,4,-5,6"

#numbers grater than 1000 will be ignored
StringCalculator.exe "1000,2,3,4,5,6"
```
