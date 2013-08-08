TextDollar
==========
You are given a positive integer number. This represents the sales made that day in your department store. 
The payables department however, needs this printed out in english. 
NOTE: The correct spelling of 40 is Forty. (NOT Fourty)

Input sample:

Your program should accept as its first argument a path to a filename.
The input file contains several lines. Each line is one test case. 
Each line contains a positive integer. eg.
3

10

21

466

1234

Output sample:

For each set of input produce a single line of output which is the english textual representation of that integer. 
The output should be unspaced and in Camelcase. Always assume plural quantities. 
You can also assume that the numbers are < 1000000000 (1 billion). 
In case of ambiguities eg. 2200 could be TwoThousandTwoHundredDollars or TwentyTwoHundredDollars, 
always choose the representation with the larger base i.e. TwoThousandTwoHundredDollars. 

For the examples shown above, the answer would be:
ThreeDollars

TenDollars

TwentyOneDollars

FourHundredSixtySixDollars

OneThousandTwoHundredThirtyFourDollars
