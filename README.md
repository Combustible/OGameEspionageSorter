OGameEspionageSorter
====================

Summary:
====================
Simple Visual Basic .NET forms project for easily sifting through espionage reports obtained while playing Gameforge's OGame.
It was designed to allow you to quickly add hundreds of espionage reports to it, sort them by fleet units, defense, distance, etc. You can then quickly choose where to send your ships to.

Features:
====================
Expandable tree-graph representation
Sort by Fleet Units, Defense Units, Coordinates, Shortest Distance, Metal, Crystal, Deuterium, Unweighted resources, and Weighted Resources.
Can copy all parsed reports to clipboard, or just one.
Able to crop down to the top X entries
Undo last deletion
Selectable duplicate functionality (overwrite exiting, ignore new, ask)

Installation:
====================
Well, there isn't an installer currently, and I'm not sure I ever want to set one up. For now, you can download the most recent compiled binary here on GitHub (in Espionage Sorter/bin/Release), or compile it yourself using Visual Studio 2012 Express. It only runs on Windows, and depends on .NET framework 3.5. Just save the executable someplace and you can run it (it will create a .ini configuration file in the same directory).

Usage:
====================
Currently, data is transferred into the program via drag + drop. The best way to use it is to set your OGame settings to display full espionage messages in your inbox, open your inbox, hit control+a to select everything, and click and drag that selected text onto the face of the Espionage Sorter application. This works from most Windows programs, including text editors, etc.

Display:
====================
The interface is decidedly minimalist, and doesn't describe what any of the numbers mean. Here's the key:

Blue name - No fleet/defense
Green name - Defense only
Orange name - Fleet only
Red name - Both defense & fleet
Purple - Defense and/or fleet unknown, need to rescan with more probes

Format of name header:
[Coords] - Weighted Resources - Number of default ships to carry resources (rounded up) - Player Name

Second line:
Metal Crystal Deuterium

See the two screenshots for an idea of what the interface looks like.

Licensing:
====================
Still thinking about how I want to license this. For now, just send me a message.
