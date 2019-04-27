# _C# WordCounter.Solution_

#### _Epicodus C# Week 1 Individual Project, 04/26/2019_

#### By _**Marc Davies**_

## Description

_The logic for this program compares a word against a sentence and returns the number of times the word is included in the sentence. For example: "coding" / "I love coding" / result: 1. See specifications for more information._

## Setup/Installation Requirements

* _Clone from GitHub_
* _In your terminal, navigate to WordCounter.Solution/WordCounter/Models_
* _$mcs Program.cs RepeartCounter.cs_
* _$mono Program.exe_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| If the user inputs "I love coding" as a sentence, and "coding" as the word to find, the program will return 1. | "I love coding" / "coding" | 1 |
| If the user inputs "I love CODING" as a sentence, and "coding" as the word to find, the program will return 1. The program is not case sensitive. | "I love CODING" / "coding" | 1 |
| If the user inputs "I love coding I think coding is great!" as a sentence, and "coding" as the word to find, the program will return 2. | "I love coding I think coding is great!" / "coding" | 2 |
| If the user inputs "I guess decoding is cool too." as a sentence, and "coding" as the word to find, the program will return 0. The program only looks for full word matches only | "I guess decoding is cool too." / "coding" | 0 |

## Known Bugs

_The program will not count a match when the word has punctuation after it. For example "I love coding. I think coding is great!" will return a result of 1. To be fixed at a later time._

## Support and contact details

_Please contact me at marcdaviesriot@gmail.com if you run into any issues or have questions, ideas or feedback._

## Technologies Used

_C#_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Marc Davies_**
