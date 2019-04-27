# _C# WordCounter.Solution_

#### _Epicodus C# Week 1 Individual Project, 04/26/2019_

#### By _**Marc Davies**_

## Description

_The logic for this program compares a word against a sentence and returns the number of times the word is included in the sentence. For example: "coding" / "I love coding" / result: 1. See specifications for more information._

## Setup/Installation Requirements

* _Clone from GitHub_
* _In your terminal, navigate to WordCounter.Solution/WordCounter/Models_
* _$mcs Program.cs RepeatCounter.cs_
* _$mono Program.exe_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| The program looks for a word in a sentence and checks if the word appears in the sentence. | "I love coding" / "coding" - I chose these values because they clearly explain what the specification does. | 1 |
| The program is not case sensitive and will return a match no matter which casing is used. | "I love CODING" / "coding" - I chose these values because they clearly show that both values have a different casing. | 1 |
| The program will count how many times a word appears in a sentence. | "I love coding I think coding is great!" / "coding" - I chose these values because they build upon the previous specifications and add another layer of specificity, in this case coding re-appearing later in the sentence.| 2 |
| The program will only take full matches into account, partial matches do not count. | "I guess decoding is cool too." / "coding" - I chose these values because they're using a similar but different word which explains what this specification does.  | 0 |

## Known Bugs

_The program will not count a match when the word has punctuation after it. For example "I love coding. I think coding is great!" will return a result of 1. To be fixed at a later time._

## Support and contact details

_Please contact me at marcdaviesriot@gmail.com if you run into any issues or have questions, ideas or feedback._

## Technologies Used

_C#_

### License

*This software is licensed under the GPL license.*

Copyright (c) 2019 **_Marc Davies_**
