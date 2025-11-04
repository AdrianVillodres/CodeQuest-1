# CodeQuest

## Description
this is a terminal game based in a mage. The diferent chapters are the levels of the game. In the first chapter you train to become a grat mage, in the second one you go to a cave and open doors to defeat the dragon, and in the third one you loot the cave to obtain bitcoins.

## Test Game

Chapter 1

case = “Adrian” 



|#Instruction |#Iteration |Variables ||||
| - | - | - | :- | :- | :- |
|- |- |name |randNum |Power |Condition |
|1 |- |Adrian |0 |0 |- |
|2 |1 |Adrian |Random(4) |power + Random(4) = 4 |- |
|2 |2 |Adrian |Random(2) |power + Random(5) = 9 |- |
|2 |3 |Adrian |Random(7) |power + Random(8) = 17 |- |
|2 |4 |Adrian |Random(3) |power + Random(1) = 18 |- |
|2 |5 |Adrian |Random(8) |<p>power + Random(10) </p><p>= 28 </p>|- |
|3 |- |Adrian |8 |28 |power < 20 = false |
|4 |- |Adrian |8 |28 |power >= 20 && power < 35 = true |
|5 |- |Adrian |8 |28 |Output: “Necromancer” |

Chapter 2

case = 2, 3, 1 



|#Instruc tion |#Iteratio n |#Iteratio n |#Iteratio n |Variable s |||||
| :- | :- | :- | :- | :- | :- | :- | :- | :- |
|||||correct Code |codeInp ut |counter |secretC ode |Condition |
|1 |- |- |- |false |0 |3 |0 |counter > 0 && correctCode == false = true |
|1 |1 |- |- |false |2 |3 |Rando m(2) |codeInput == secretCode = true |
|1 |1 |1 |- |false |3 |3 |Rando m(5) |codeInput == secretCode = false |
|1 |1 |2 |- |false |3 |2 |Rando m(3) |codeInput == secretCode = true |
|1 |1 |2 |1 |true |1 |3 |Rando m(1) |codeInput == secretCode = true |
|1 |1 |2 |1 |true |1 |3 |Rando m(1) |OUTPUT = “You have unlocked the final level. Be prepared for the final battle!” |
|1 |1 |2 |1 |true |1 |3 |Rando m(1) |counter > 0 && correctCode == false = false |


chapter 3 



|#Instructio n |#Iteration |Variables |||||
| :- | - | - | :- | :- | :- | :- |
|||bitcoinFou nd |bitcoinCou nter |i |condition |Condition |
|1 |1 |Random(3 2) |bitcoinCou nter += bitcoinFou nd(32) |0 |bitcoinFou nd >= 5 = true |i < 5 = true |
|1 |2 |Random(3 ) |bitcoinCou nter(32) |1 |bitcoinFou nd >= 5 = false |i < 5 = true |
|1 |3 |Random(5 0) |bitcoinCou nter += bitcoinFou nd(82) |2 |bitcoinFou nd >= 5 = true |i < 5 = true |
|1 |4 |Random(2 0) |bitcoinCou nter += bitcoinFou nd(102) |3 |bitcoinFou nd >= 5 = true |i < 5 = true |
|1 |5 |Random(5 0) |bitcoinCou nter += bitcoinFou nd(152) |4 |bitcoinFou nd >= 5 = true |i < 5 = true |
|2 |- |Random(5 0) |bitcoinCou nter |5 |- |i < 5 = false |
|3 |- |Random(5 0) |bitcoinCou nter |5 |- |<p>OUTPUT </p><p>= “Your magic card is still integrated. It's time to defeat another dragon!” </p>|



