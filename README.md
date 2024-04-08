# Description

Polyrhythm Player was originally intended to assist my music production through audibly presenting polyrhythmic sounds.
To learn more about polyrhythms, [Click Here](https://www.beyondmusictheory.org/polyrhythms/)

There are plenty of polyrhythm demonstrators online, but none (that I could find) that are created in 3D space. I thought it would be a good project for me to create exactly that.
I chose Unity and C# because I had previously used Unity for some Game Jams.

## As of writing this 
I have these main objects -  
Metronome
: Holds the BPM (Beats Per Minute) and Start/Stop function that the NotePlayer's will respond to.
: For example, if the Metronome is on and has a BPM set at 120, it will tick twice every second.

NotePlayer
: Catches the tick from the metronome and plays a sound at that moment. NotePlayer has its own Mute/Unmute, Volume Slider, and RhythmGrid.

RhythmGrid
: A 4x4 grid that allows the User to select the Pattern that the NotePlayer's sound will play in.
: For example, selecting a '4/16' pattern on the grid will set the NotePlayer to play a set sound as a "Quarter-Note" (in musical terms).

## Ideas 
https://github.com/juancocina/Polyrhythm-Player/blob/main/Assets/Scripts/Ideas.txt  
Click this link to see the evolution of my ideas and my thought process for developing this project.

# The Future
I intend to learn more about Fast Fourier Transform and other algorithms that are used to analyze repeating patterns over time.
I think this would be a well rounded project if I can include more DAW (Digital Audio Workspace) functionality, such as Equalization.
As well as sandbox capabilties to allow the User to place NotePlayer's around a designated area, choose the sound for the NotePlayer, and its Pattern.




