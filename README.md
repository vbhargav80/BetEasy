# BetEasy

Please open the solution in visual studio 2017, restore nuget packages (which should automatically happen on running the build) and run the solution.

## Assumptions

Both the data files have been read and horse info from both files has been merged into a single resultset
Some more assumptions are documented in code via comments

## TODO if i had time

Add more unit tests
Refactor HorseService and inject 2 different transformer classes into it which handle transformation of the different provider models into the common Horse model