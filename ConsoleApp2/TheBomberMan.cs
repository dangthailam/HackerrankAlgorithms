﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public static class TheBomberMan
    {
        /// <summary>
        /// https://www.hackerrank.com/challenges/bomber-man
        /// </summary>
        static void Algorithm()
        {
            //string[] inp = new string[]
            //{
            //    "...O.O.O.O.........O.O..O.O..O.....O.OO.O.O...O....O..OOOOO......O....O....O.O...O.O.OOOOO.OO..O..O....O...O.OO..O....O.OO.....O..OO......O....OO..O....OO....O.................O......O...",
            //    ".O.O.O.O..O.O.O.....OOO...OO.OOO......OOOO.OOOOOO.OO.......O.O.O.OOO..OOO..O....OO.O....O.O..OO...O...OO..O.....O...OO....O..OO.O....O.....OOO.......OOO.....O.O.O.........O.......OO..O...",
            //    ".O.......O..O......OO..OO...O.....O.O.OOO...O.OO...O...O.OO.OO...O......O.O..O.OO.O.OO.....OOO.O.O.........O....OO.O......OOO.O....OO...OO.OO....O..O..O..OO..O..O.O..O.......O.OO.O...OOO.",
            //    "..OO..O.O...OO.OOO....OO.....O.OO...OOO..O.....OO.O.OOOOOOO...O...OO...O.OO.O.........O...O...OO...........OO...O.........O.O.............OOO.O.OOO...O.O........O.....O.........O..O..O...",
            //    "......O...........OOOO....OOO..OO....OOOO.OOO.O......O..O.OO..OO....O.........O.......O.....OO...OO.O.O.O.O.O...OOO.O...O.........O.O....OOO.O....O.O.O.....O....OO..O....OO...OO.....OOO..",
            //    "O...O...O..OO..O...OOO.....O..O...O....O.O.O.OOO....O.O.OO....OO...O....OO.......OO....O...OO...O.O.......OO...OO...OO..OOOOO.O.OO...OO.O.O........O....O.OO..O....OO...OO..O...O.O..O.....",
            //    ".O.O.....O......OOO.....O......O.....O.O.O.OOO.....O..O.O..OOOO.O.O.OO....O..O..O...OO..O......O...O..OO.O.O.OO....O...O...O.O...O........OO.O.......O.O..OOO.O.O..O..O...O....OOO..O....O.",
            //    ".....O..OOO.......OO..O.O...O....O.O...O.O..O..O.....O.OOO..OO...O...OO.OOOOO......O.O.......O.O..O.....O.OO...OO....OOOOO......OO..O....O.........OO.OOO..O.O.O...O..OOOO..O........O.....",
            //    ".OO..O.OO....O..OOO.......O.OO..O....O.O.......O.O...O..O.O......O.O....OO..OO...O.O.........O....O..O....OOOO.O...OOO....O...O...O...O.O..OO...........O...OO...OO.O.......O..........OOO.",
            //    ".O...O..O..OO.O.O...O..O.O.OO.O.O.OO......OOOO.O..OO.OO..O..........O..O.O.O.....OO......O...OO.....O...............O.O...O..O.OO..O........OO.O......O.OOOOO...OO.OO..O.......O....O...O..",
            //    "......O....O.........OO...OO.O...O.O.....O..................O...OO..O.OO...O.O.O...O.O......O.OO............OO.O.O.O..O.O..O.........O...........O..OO.O..OO.O....O...O...........OO....O..",
            //    ".O...O.OO.O..OOOO.OO....O..O.OO.O..O...OOO.O......O...OO..OOOO.OOOO.O..OO...O.OO..O.OO.O.OO.....O.O.O...OO.O.O......OO.OO..O.OO.OO...OO..O....OOOOO.O.....O..O...OO.....O..O..........OO.O.",
            //    "...O...O...O.O.O.O....O........OO.O.......O.O.O.O.OO...O..OOO..O.O.O....O..O.OO..O.....O...O.OO.O.O..O.....O.O.O..O...OO.OO...O......OO......O.....O.....O..OO..OO.O.......O.O..O.....O..OO",
            //    "...O.OOO.O.OOOO.OO.OOO.........O.O.O......O.O....O.O.....OOO.OOO...O..O......O..O.O.....OO.....O..O....O...O....O.O..O....O.O.O.O..O.......OO.O..O..O.OO.......O...OO....O......OO.........",
            //    "...O..OOO..O.OO.O.O........O....O......O....OOOOO...OOO..OO....O.OO..OOO..O.......OO.OOO.O......OOO..OOO...O..O.O...O..O...OOO....OOO....OO..OO....O.............O.O........O.O.O..O....O..",
            //    "O...O..............O.........O..OOOO...O..O....OOO...O.O..O.O.OOOOOO.O.O...O.OO.O..O..O.O....O.O.OO...OOO..OOO..O..O.....OO..O.....O..O.O.OOOO.........OO.O..OO...O..O......O...O.OO.O.O.O.",
            //    "O.......O.....OO.O.O.O...O...O....O...O.O......O..OO........O...O.O.O.O....OO.O..O..O.O.OO..O....O.......O.O.......O.O.......OOO.........O.OOOOOOOO..OO.OO.O..O.OO...O.OO.O.O.O..OO...OOO..",
            //    ".OOO..O....O.....OOOOOO..OOOO...O...O.O...OO..O.O.............O.....OOO..O.OOO....O.O..O.O.OOO.O....O..O..OO...OOO...O.O.OO..O...O...OO..O....OO...OO.O...O.........O........O......O...O..",
            //    "OO...O..O.O...O....O.O....O...O.O..O.O.OO...O...O.OO..O........O...OOOO.O....O...O...O.....O...O...O....OO.O.........O...OOO..O.O..........O.O.........O....O.....O...O..O....O...O..O.....",
            //    "...O.......O..OO.....O...OOO.....OOOO....O.........OOO.O.....O..O........O.......OO.O.O.O...OO....O..........O........OO.OO.....OO.OOO.......OO....O....O...........O.O...O..O...O...O.....",
            //    "O...O.O..OO.O.O.O..OO.O.....O.O..O.O..OO....OO..O.OOO...O.......OO.....O...O.....OO..O....O..........OO......OOO.OO.O....OO..........O.OO.O.OOO......OOO......O....OO..O.O..O.O....OO..OOO.",
            //    "..O.......O....O..OO.....O........OOO.OOOOOO...OOO...O.O......O..OOO.O.O..O.O.OO.O.OO..O...O..O...O.O.O.........O..O..OO.O.......O..OO.O..O....OOO..OOOO..O..OOOO....OO.O....O..O..OO.O...O",
            //    ".O....O..O...O.O..O..O.........O..O.OO...OO...OOO.O..OO...OO.OOOOOO..OOO....OO...O..O..OOO.O..O......O....OO..OOO...OO.O.O..OO..O.O.......O.O.........O.....O....O..O.OO....O..O.O.OO..O..O",
            //    "OO..OOOOO......O.....OO......OOOO......OO.....OO.....O......O.......OOO.....OO.........O..OOOO...O......O.O.OO..OO..O......O.O.....O....O.O....OO.O...O....OO..O.....O.O..O.....O..O.OOOO..",
            //    ".O..O....OOO.O...OO.O...O.....O.O.....O........OO.OO.O........OO..OO.......O.O.O......OOOO...O..O.OO....O.OO..OO..O....OO..OO.OO..OO....O...OOO.O......O.OO.....OO..O.O..OO.O.O...O.O.OOO..",
            //    "..OO.........O....O....OOO.....OOO.........O.O..OOO.O..O..O..O.OO..OO....O.......O..O..OO....O..O.....O..O......O........O.O.OO....O.O.........O..OOO...OO...O.......O..OO.O..O.....OO.O.O.",
            //    "......O..O........OO....OOO..O...O..O..OO...O..O...OOO.O.O..OOO..O.O..O...O....OO.OO..O...OO.OOOO..OO.O..O..O...O....OO..OO.OO....O..........O.O.OOO........O......OO.......O..O....OO.O.O.",
            //    "OO.OOOOOOO..O...O....O.OOO...OOO.OO.O..OOO.O....O.O.O...O.OO...O.........O......O....OOOO.OOO..O.........OOO.OOO.O...........O.O..O......O.......O..O.........O..OO.O.OOOOO...O.O.OOO...OOO",
            //    ".O...........OO...OOO.....O....O....OO...O..O..OO..O..O..O..........O.O.O.......O...OO.OOOO.O..O..OOO......OO..OO..O.O....O..O..O.OO...OOOO...O...OO.......O.O....O.O...OO.O...O....O....O.",
            //    "OOO...O....O...OOO.....O.O.......OO...O.OO.O..O..O.....OOO.OO........O.OO....O.....OO.O...O..OOO.........O.O.O.O..O...O..O...O...O........OO....OO....O..O...O.OO...OOO..OO.OOOO.....O.O..O",
            //    "..........O.OO.OOO....OO..O..OOO.OOO.O........O....O........O..O..O.O....O.O.......O...OO..O...OOO.O.OO.O.OOOO.OO.O.O.O...O.....O.O.O....O.OO...O...OO.O..O..O....OOO...O..O.....O..O...OOO",
            //    "...........O.O...O.O....O..O..O..O..O........O..OO....O.....O.O...OO..O..O....O..OOO........OO........O.OOO....O..O..O.O.....O.O.....O.O.............OO.O..OO.OOO..O..OO...O..O.O...O...OO.",
            //    "..OO..O..O.O..O..OO..O......OOOO..OO..O.O...OOO.OO..OOO.OOOO..O.O....OOOOO.O...O............O........OO.OO...OOOOO...O......O.OO...O.......OOOOO.........O.......O.O....O...O.OO..O..O.OOO.",
            //    "O.O....O...O..O.OO..O.O.OO.O..OOOO.....O...O.OO.O.OO.....O........O.OO..OOO..O....OO.....O..OO...O.....O......O..OOO.O.....O.OOOO..O.O....OOOO.OOO..O.OO.O...OOO.O........OO...OOOOO...OOO.",
            //    "..O..O.O..O.O.......O.O..OO..O.O......O.OOO.......O..OO..O...O...O..OO......OOO...OO......O........OO..O..O.OO...O.O.O.O..OO.OO...O..OO.O..O...OO.OO....O.O..OO....OO...O.......O..O.....O.",
            //    "O.OOO.O.....O.OO........O......O.O..O........O......O.O....O..OOO..OO....OOO..O.O..OOOO..OOO..O.OO..OO......O.....OO..OOOO....O.O.O....O.O......O..O.....O.......O.O.......O...O........O..",
            //    ".O.O.O.OOO.O...O.OO.O...O......OO....O.O.O.OO.O...O.O...O.OO.O..O.O.O.....OOO.....OO..O...O...OO.O....OOO..OO.O.......O...OOO..............O..O.....O...O...........O....O.....O.O..OOO..O.",
            //    "..OO........OOO.O.............O..O...O......OOO..OO...........O....O..O.O...O..O..OOO.O......OOO.OO...O..O........O..OO....O.O.O.OOO...O.OOO..O.O..........OO..O.O.O.O.O.O..OO..O....O.....",
            //    "...O.O.OOO....O.O.OOOO.........O.O..OOO........OO.O......O.O.O.OO.OOO.OO....OO..O.O.O....O...O...............OO..OO..OO....OOOOO.OO.OOOO.O.OO..O.O.....O..O...O..O..O.O.OO.....O.....O...O.",
            //    "...O.O.O.....OO...OO.O...OO.......O.OOOO..O...OO.OO.OO..O.O.OO.OOO......O..O..............OO..OO.O..O..OO....O..O.O..OOO.......O....OOO..O.O.O.OO.O...O...O........O.O.......O..O...O....OO",
            //    "OO.....OOOO..O.O.O...O.OO.....OOO.O..OOOO.....O....O..OOO.....O...O.O.......OOOO.O..O.OOO..OO....OOOO.O.O..OOOO....O.........O....O....O..O....O...O....OO..OO..O..O..O.OOO...O..OO........",
            //    "...O.O.O...O...O...OOO....O....O.O.OO.O.O..O..OO.OO...OO.O.OO.O..O.O...OO......OO..O.O.O..OO..O.OO......O...O...O.O....O...O..O.....O.O...O..OOOOO...O....OOO.........O..O.O...O....O..OOO.",
            //    "...O..O...O.O.O.......O..O......O.....O...O.OO....O.....OOO...O..O.O....OOO..O.OO....O.OO...O..O..O.O........O..O.OO....O...O.....O.O...OO.O......O....O.OO....O......O..O..O...O..O..O...O",
            //    ".O........O.O.OOO....O.O..OO.O.O.....O...O......O...O.OO.O.O..O.......O..O..O...O...O..OOO....OO...............O..........O.O............OO.....OOO.OO..O........O.......O.....OOO.O..O.O..",
            //    ".OOOO.....O.....O..O..OO...O...O.O...O..O...O......O....O..O..OO.O.O...OOO..O.......O.OO..O..O...O..O..O.O....O..O.....O..O.....O.....O..O...OOO.OOO.......O.O.O..O.....O..O.OO.O......O...",
            //    ".OO.O..OO.OOOO.OOO.O...OO.OO...O..OOOO..OO..O.O.O.OO.OO....O...O.O..OO.OO.......O...O..O...O..O.O...O.OO.....O.....O...O..O.......O..O........OO..OOOO...........OO...O.O..O.O....OO..OO...",
            //    "O..OO......OOO...O....OOOOO..OO......OO.OO...OO.O......OO....OO.....OOO.O...O.OO.O.O..O.......OOO.....OO.....OOO..OOO...O.O...O.O........OOO..OO....OOO..OOO...O.O.O...O.O.OOOOOO.O.....O..",
            //    ".O....O.....OOO..O..OO.O......O..O.O.O...OO.O...OOOO.....O....O.OO.......O.OOOOO...O.O..OO.O...........O.OO...O....OO.......O..O...O.O......OOOO...O..O.OO.....O...OO..O.O.OOO...OO.......O",
            //    "..O...OO.OO.O..O.O.OO...OO....OO.OO.O.O.....OOOO..O...OO...OOO.O...O..O.O....O.O..O.OOO.O.....O....O....OO.OOO..OO...OO......OOO..O........O.O.......O....O..O.....OOO..O....O.......O.....",
            //    "....O...O.....OO...O.....O...O.......OO.....O........OOO.OO....O..O...O.OO.........O.O..OOOO.OOOO..O.O..O..O..O.OO....O..O....O......O.O...O.OO.O..O.....O...O.....O.......O.O.O..OO......O",
            //    "O..O..O...O.....OO..O.O...O.....OO.O....O.OO.O....O.O......O.O.......O...O.......OOOOO.O...O..OO..O.O.O......OO......OO.OOO...O.O.O...O...O.O.OOOO....O..O.O.O..O...OO..OOO..OO....OO...OO.",
            //    ".O.OO..OO.O.OOO.O.O.O....O..O....OOOOO......O..OOOOO.....OO........OO.OOO..O.........OO.........O.O..OO...O......OOOOOO.O.OOO..O..O.OOO..OO...OO..........OO......O.O......OOO.OO.O.......O",
            //    ".....O.O....O..OO..OOO..OOOO..O...........O...O..O....O.OO..OO.O........O.OO.O..O..O.......O..O.O..O...O.OO........OO....O.O...O.O...OO..OO.O...O..OO..O..O.OO.O.OO....O.OO.......O.O...O..",
            //    "OO........O..O.OO.O..O.OOOOOOO......OO.O.O.O..O...O.......OO......O..O........OO.OOO..OOO.OO........OO..OOO.OO.OO.O..OO...O.O..O...........O.O.OO..OO.OOOO..O.........O..OO..........O.O...",
            //    ".O.O...O.O...OO..O....O..O.OO.O.OO...O...O.OO.....O.....OO..OOO........OO.O.O..........O......OOO.OO...O.....OO.......O.O.O.O......OOO.O.O...O....O.OO....OOOO..OOO....O.O.O...O.OOOOO..O..",
            //    "......OOOO....OO....OOO.O.O.O....O..OOO..OO.......O..........OO.OO.O..O...O..O....OOO.....O.OOOOO....OOO..O....OO.OOO.OO.OOO.O..O..O.....OO.O....O..O...OOOOOO.....O..OOOO..O..O.O.....O...",
            //    "OO.O..OO...O..O.O.O.O..OOOO.OOO....OO..O.O..O.O.O..OO..O.O.O.OOO..O....OOO.O........O.OO....OO.....O...O..O..O..OOOOO..O..O...O.OOO...OO...O.O....O..O.O....OO....OO.O..O..O...O.O.O.O.....",
            //    "O..OO....O...O..O...O........OO.O.O..O.O..OO...OO....OO........O.OO.O.OOO..O..OOOO..O.O..OO.O.O...........O....O..O...OOOOO........O.OOOO........O......O.O.O.OO..OOOO..O.O.OO..O...OOOO.O.",
            //    "...O.O........O........O...........O..O..O...OO....OO..O....O...........O.....O..O..O..O.O...O...O....O...OO.OOOOO.OO.OOO.O.O....OO...O..O.OOOOO.O.O.O.O.O...O...O..O.O.O......O..O........",
            //    "O....OOOO...O.O..O...O.O..O..OOOOOOO...O.O....O...O..OOO.O.O.O..OO...OO....OO.....O...OOOOO..O.............O.....OO..O......O.OOO......O..O..OOO.O...OOOO..O.......OO...OO..OO.....O...O.O.",
            //    "OO....OOOOO...OO...O.O.OOO....OO............O...OO...O......O..O..OOOO.....OOO.OOO..O.OOOO....O...........OOO...O....O....OOOO.....O.OOO...O...O.....O..OO.OOO..OO.....OOO.O.O....O.O.....O",
            //    ".OOO..OOO.O..O..O.O......O.O.O...O.....O..O...O....OOO.O.OOO..........O......OO..O......OOO.....O....O.O...OO..O..O...O.OO..OO.O..OO..O..O....O...O.OO.O...O...O.O..OO....OO....O.......O..",
            //    "..O....O..O.OO.OOO...O..O...O.........O......OOOO......O......O....O.O..O..OO.O......OOOOOOO....O.O..O.O......O..OOOOOO.....O...OO......O.......O..O...O.....O.O...O.......O...O......O....",
            //    ".OO.......O....OOOO...O...O.O...O..O...O...O..................O.OO.O..O..O..OO...O....OOO..OO...OOO...........OOOO.O..O.OO.....O...OO.OO.O.O...O.OO....OO........O..O.OO..OOO...OO.O...OO..",
            //    "..O.O.O...O..O.....O..O...OO......OOOO..O.O.O.OO..O.O.....O.OOO......O..................O.OO...OO.OOO.......OO.O...O.....OO...OOO...O..OOOO.......O.OO......OO......O.........O......O..OO.",
            //    "OOOO...O..OOO.O..........O...OO.OOO.OO.....O......OOO..O.O.O....O..O.O..O.......O.O.....O...O.....OO.OO.OO.......O...OO.O....O......OO......O......OO...........O.OOO.O.O.OO...O........O.O",
            //    ".OO......O......OO...O.O.......O..O..OO.O.....O...O.O.OO.OO....................OO....OOO.OO.......OO.O...OO.....O..O.....O..O.O.O.....OO...OO..O.....O..OO..OOOO.O..OOO.O.O....O.OO.O.OO..O",
            //    "....O......O..O....O...OOO........O.....OOO....OOOO...........O...........O.O..O.OO...OOOOOO..O...O..O........OOO.OO....O.O.O.O.O.O.O.O.OOO.OO.....O.O.O.O.O.........O.OO...OO..OOO..OOO..O",
            //    "O.O.O...O.O.O....O.O..OO..O...............OOOO.O...OO....O..OO..O....O...O..O..O.....OO.O..O.OOOO.O.O....OO...OOO....OO.O....O..O....OO........O..OOO..O.O.OO...OO.O.O....OO.OO......O...O.",
            //    "O.......O..O.....O...OO...O..OOO..O.......O.O.....O..O.OOOOO.O...OO...O....O.OO..O.O.......O......O...OO..OOOOO...O..O.OO..........................OO.OOO.O....OO...O......O.O.....O.O.O.O.",
            //    ".......O......O.OOO..OO.OO...OO.O..O.......O.O.....O......O..O......O....O...OOO...O.....O..O.......O...O........O.O....O..O..OOO.O.O..O...OO..O.OOOO.O...O.O..O..O.OO.OOOOO.O.........OO..",
            //    ".OO.....OO..OO.OOO.......OO...OOOOO..OO........O......O.O.O.OOO...O..O.....OO..OO..OO.O..O.OO....OO..O........O....O....O........OOO.O.O....O....O.....O.O.OO.O......O..O..O..O...O........",
            //    "..O.O...OO.O...O.O....OOO.O...O..........O.O..O....O..O.....O...OOOO...O.O.OOO.O..O..O..OO......OO..O.........O.OO..O..O...OOOO.O...O.OO......O..O...O.OO.O..O.O...OO..OO.O....OO......O...",
            //    "..OO....O..O......O...O......O....OO.OO.O.O.O.OOO....O..O.O.O.O.......O.O.......OO..O....O.O..OO....O......O.O..O...O.....OO....O...OO.OO.O.O..O.O......OO.O....O....O..OO......O..O......O",
            //    ".O.O.O..OO.O..OO...O....OO..O.OOOO.O.O......O.O....O...O....OO.O.OO...OO.O...OOOO.O..........O......O..OO.OOOOO.O......O...O...O..O....O....O.O......O.O.OOO.O.O.O..O.O....O..OOO.OO.O.....",
            //    "..O...O.O.............O...OO.O....O...O.O...O..O.OO..O.OO...OO..O..O.OO.O..OO........O....OO..O..OOOO....OO....OO...O......O..O.............O..O..O.OO.O.O.O........O.O.OOO..OOO.OO.OOOO...",
            //    "...O.O.O.........OOO..OO....OO..O.OO..O.O....OO.O......OOO....OO..O..O.O........OO.OOOOO........O..O.O.OO..O....O.O.....OO....O.....O.......O.O.......O..O.O......O.O......O.OOO....O.O.O..",
            //    "....O..OOO.O.O.O....O...O..O...O..O.O.....O...............O..O.......O....O.O..O.O.....OO..O.O..O....O...O.....O..O.O....O..OO.O..O........O..O.O...O.O.O.O.....O.OO.OO..OO.O.O..O..OO..OO.",
            //    ".O.O.O......O...O....OO.O...O..OOO.OOOO...O..O...O....O.OOO.O.....O.O.O.O.......O...O...O..O.O......OO...O.O.O..O...O......O.OOO.O....O.O....O..O......O.O..OOOO...OOO.O......O..O......O..",
            //    "OO...O...O.O.................O..O.OO.....O..OO...O....O..O..O..OO...O...O..OO..OO..OO...O..O..O..O......O.OO..O..OO.O........O.......O...OOO.....O..OO......O..O........O.O.......OOOO..O.O",
            //    "O........OOOOOO.O.O..O..O...O...O.....O.O..O.OO..O..O...O.....O....O..O.O...OO....O...O..OO...OO..O....O..O...OOO.O..O...OOOOO.OO..O..O......O.O.OO..O.O.....OO.O....O......O...O.....OOOO.",
            //    ".OO..O......O..O...OO.O.O..O..O........O.OO...O.O...O..O...O..OO..OOO.OO...O.....O...O..OO..O.OO.O...OOO.OO.OOO.O.......O.O..OO..O.O.O.OO.O.O..OO.O...............O.OO......OOO.....O.OOO.O",
            //    "....O..O.....OO.O......O...O.O...O...O......O......OOOO.......OOO..OO..OO......O.OO..OO.OOO..O...O...OO.OO...O....O...O..O...OO..OO.OO...OO....OO...O.....O.O..OO.....OO..O..O.O..O...O....",
            //    "O.OO......OO.O....OOO.O....O...OOO.O...O.O..O.O.O..O.O.O..O..O.O..OO.......O....O.OOOO...O...O....O.........OO.O.OO.....O..OOO.O..OOO.O.O..O..O........O...O.O..O..OOO.OO.O..O.O...OOO..O..",
            //    "O.....O...OO.........O.OOO.OO....OO..O......O..O.....O..OOOO.....O.....OO..O..O....O.OO...OO.....O..OOO.O...O......O.O.....O.O....OO.O..OOO.....OO.O...OOOOO.......OO..O...O.OO.OO.....O.OO",
            //    ".OO.O.OOO..O...OO...O..O..OO.O....O....O.O.OO.....O..OO.O..O.....O..OO..OO...OO....O.O.OOO.O...OO....O..O..O....O..O.O.OO.O..O.O.O.........O.OO..OOO..O.OOO.OOO....OO.O.OO.O.OOOO.O.O...O..",
            //    "OOO..OOO....O...O..O..OOOO...O.O.O......O.O.O.......OO.OO....OO.O.........OOO..O.OOO...OOO..OO.O.....O...O....O.O.....O...OOO..O.....O.O.O.OO.O.OOOOO.O....O..O.O.......O........O..O..O..O",
            //    ".......O.O...O.OO...O.O.O....O...O...OO...........O....O...OO.O...OO.................OO.O.O.O.OOO.....OO.OO..O...O.O.OOOO.O..OO..............O.........OOO......O..O.OO....O..OO...O.....O.",
            //    ".......OO...O.O.O.O...OO..O..O.....OO....O......O.O.OO.OOO.....OO..O...O...O.....O..O..O.OO.OO..O....O............O.OO.O....O....O..OOOO.....O...OO....O....O.O.O.O.O.O..OO....O...O...O...",
            //    ".....OO.....OO.O.OOO.OOOOO.....O...OO.O.O.OO.O....OO.....OO.O..OOO.....O....O..........O.O.O...O.O.O.O.O.....OOO.O.OO.O.O...O.O.OO..O.OO.......O...OO.OO.O.O..OOO..O...O.....O...O.OO..O..O",
            //    "OOOOOO..O..O......O.........O....O.O.OO....O..O.OO.O..OO..OO.O.O.O.O...O.O....OO..OO......O......O.O.OO...OO....OO.O.......O..O.O.O.O...O.O.O..O...O..OO.O......OO..O.O.......OO.OO.O...OO.",
            //    ".O...O..O.O.OO..OO......OOO...O.O.OOO.O...........O..O......O..O.O........O.OO.........O.O.O...............OO......O...O.OOOO...OO.......OO.......O....O...O.....O.O.........OOO..OO..O.O..",
            //    "OO.....O...O.O..O.O..O....O....OO..OO..OOOOO..OOO.OOO.O...O...O.O....O...O...OOO........O....O.......O..O...O...OO.O...OO...O.O.....OOO.....OOO.O.O.OO..OO.O.........O......O.OO.OO..OO.O..",
            //    ".O..O.OOOO.O..O..O.....O.O.O......O.....OO......O......O..OO..O...O.....OO.O...OOO....O...OOO.OO...OO..O..O...O.......O..OOO......O.OO.O..O..........O....OO.O.O.......O....O...O.O.....O.O",
            //    "OO.........O..........OOOO..OOO....O....OO....OO.......O.O...OO.OO..O...OO........O.O..O.....O...O.....O.O.OOO..OO...O..O.OO..O.O..O.......O.OOO..O..OOO...O..OOOOOOO.OO.....O.OO....O.....",
            //    "...OO...OOO.O......OOO..O.O...O.....O...O...OOOOO....OO.O.O.OOOOOO.OO....OOO.O.........OOO.OOOOO..O.....O..O.....O.OO....O.OO.OO...O..O..OO..O....OO.O.O.O..OOOO.O.O...O.O.O...O..O...OOO..",
            //    "...O.OO....OOOO......OO....OOO.OO.O.....OOO.........OOOO.OOO..O..O......O.O..O.O...OOOOO....O.......O..O.....O...O...O.....OOO.O.....OOO..OO.O..O.....O.OOO...O..O.O.OO...O........OO.....O",
            //    "....O.OO.O....OO.O....O....O...OOO.OOO..O...O......OOOO...OO.OOO....O.....O...O.....O...O.OO....O..O.O.....O.O.OO.O.O.O.O...O.O......OOOOOO..OO.O............O...OO.O.O..O.OO..O.OO...O.O..",
            //    "..O..........OOO.OOO...O..O.............O......O....OO.OOO...O..O.OO...OO..O....OOO...OOO...OO.O....OOO..O...O.O...OO.OO.O....O...O.....OO.O.O.OOOO...OO.OO........O.O....O...........OO..O",
            //    ".OO...OO...OO.O......OO.O.O...O....O.....O.OO...OOO......O...O......O..O...O.O......O..........O.O..O..OO...O......OO.....O.OO...O..OO.O...............O..O......O.O.O.OOO....OO.....O...OO",
            //    ".O...O......O..O..O...O.....O.....O.......O.O.O.OO..O..O.......O........O.O.OO.OO..O...OO..O.OOO..OOO.....O..O.....OOO..O.O..O.....OO.O....O..O.O..O.OO.O....OO..O....O............OO.O...O",
            //    "......O....OOOOOO.OO.OOO.....O...O..OOO..OOO.O.OO.O...OOO....O...O..O.O.O..O...O.....O..O.....OO..O..O..O..O..O..OOO..O.......O.O..O.....O.OO...OOO...O....OO.....O..OO...OO..O..OO..O.OO.O",
            //    "........OO.O..OO.O..O.O.........O.O..........O......O......O.O..OO.O..O.........O...OOO..O.O........O..OOO.....O....O..O.....O....O..OO..OO....O.O.O....O..O..O....O.OO...O.O.O.OO..OO..O..",
            //    ".O..O.OOO..O.O..OO.O.O.OO.OO.O.OOOOO...OOOO......OOO.OO.OO...OO...O.O....O.O...........O..O.......O..O....O.O...OO.O.OOOOO.OOO.O.O..O......O..O..OO....O..O.......OO..O.......O...OO......O",
            //    "...O......O.OOO......O.......O....OO.O..OO......O.O.....OO................O....O...O..OO...OOO........O....O..O....O.OO.OO...O.OOOO..O.OO........OOOO.O.....O.....O...O..O..OO.OO..O.OO....",
            //    "OOO..OO.OO.O.....OO...O...O..O..O..O.......O..OO..O.....O.OOO...O......O.O.OO..OO.OO...O...O.O.....OOO.O...O..O..OO........O.OO......O.......OO.OO.O.O..O............OOO..O............O.OO",
            //    "......OO....O...OOO.OOO.O..O........OOO.O..O...O.OO...O.O.....OO...O.O.O..OOO.OO..O....OO.......O.O.O...O.O.....OOO....O....O......O.O....OOO......O..O....OO...O..O..O.OO.O.OO.....OOOOO..",
            //    ".O..OO.O.....OO....O..O..O....OO.O.....O.O.O.OO......O......O.OOO.OO...OO...O.O.OO.O..O..OO.....O..................OO..O..OOO.....OOO.O.......O..O......O.OOOO.O.......OOOOOOO...O.........",
            //    "...OO..O.OO.O....O.....O..........O.O.O...O...........O.O.....O..OO.OO....O.OOO....OOO....O...O..O..O..O....OO.OO.O.O.......OO.O.OO....O.O............OOO...OO..O..O....OO..O....O.....O.OO",
            //    ".O...O......OOO.....OO.O.O..O...O..O.OOO......O...O..OOO...O...OOO..O..OO..O...OO.O.OO......O.O.O.OO.OOO..OO.O.O.O.OO....OOO.O.O..OO..O.O..O.......O..O.OO..O...OO...O...OO.O.O.O..O.......",
            //    "O..O....O.........O...OO.OO.....O..........O..OOO....O..O.O......OOOO.OO..OO..OO.....O.........OO.........O.O.O.O...O.O...O..O.O.O..O...O..OOO.O..O....O..O...O.....O.O.O....OOOO....O..O.O",
            //    "....OO.O.OO.......O..OOO.O.OOOO..O...OOO.O..O.OO.OO..OO.......O...O....OOOOOOO.O....OOO..O..O..O.O...O.OO.O..O...O...OOO...O....O.O...O...O...O.O........O.O.O..OOO.O..OO..OO...O.O..O.O...",
            //    "O.........O.O....O..O...O.O..OO..OO....O.....O.OO.OO....O....O....O.O..O.....O.O.O.......O.O...OO..O...O...OO..OO..O.....OO.....OO..OO.O..OO.O.O......O..O..O.O.....O.O..O..OOO.OOO........",
            //    "....O..O..O.O.O...O....OO.O....OOO.OO.O..O....OO.O..O.......OO.O.OO..OO..O..O..O.O...O...O......O.OOO.O..O.OOO.....O..O.O.....OO..OOOO..O.O.O.....OO.O...O.O..O.OO.....O..O....OO..O...O...",
            //    "...OO.O.O...O........O...OOO.....OO..O...O..O.O.O..OO.OO......O.O...O...O.O..OOO.................O....OO.......O.....O......O..O.O..OOO..O......OO...O.O....O.....O......O..O.....OO....OOO",
            //    "....OO..OOO..O...OO..OO...O........OO...O..O..OO...OO.O......O.....O.O...O....OO..O........O.....OOOO.OO..O..O..OOO.......O.O..OO...........O.OOOO.O.O..O.OOOOO.O...O.O..O.OO...O...OO.O.OO",
            //    ".O..O....O....OO.O...O.OO..OO....OO........O.O...O.OOO.OO.OO.O.O.O.OOO..OO.O...O.OOOOOO......O....O..O.O..O.OOO.OOO.O.O.O.....OOO..O...OOO.O...O.........OOOOO..OO...OOO.O.O.....O.OO.OOO..",
            //    "OO...O..O.O..O..OO....OOO......OO.OOO.OO.....O.O.O.....OO.O....O.O..OOO.O..O...OO..O.OO..O..O..OOOO....O.OO.O...O.OOOOO.OO.O.......OO...O.O.O.......O...O.O.O...O......O...O..O..........O.",
            //    ".O...O.O..O.O..OO.....OOOO.........O..OO..OO.OO..O.......O.......O..O.O.OOO...OO.O.OO..O.OO..O........O.....O.......OOO...OO...O...O......O..OO.O..OO..OO.....OOO.O.O.OO..OO.OO..OO....O..O",
            //    "OO..O.........O..O...O..OO....OO.....O....OO.O.O...OO......O..O...O..O.OO..O.OO...O..O.O...........OO....O.....O...O...O...OO....O.OOO.O....O..OO.....O.O.O.OO.......OO.O....O.............",
            //    "....OOO..O......O.....O.....OO..O.O.OO.O..O.O...OO.O....OO....O...OOOO..O......O.......OO..OOO.O.OO.O.......O.....OO...O..O....O......O.O...O..O.O..O.........OO...OOO.O.....O..O.....OO...",
            //    ".............O..OO...O.O..OOOOO..OOO.....OO............O.........O.OO....OOOO.O.........O.O.....O.O.............OO.....OO...O..O.O.O....O..O.......OO.....OOOO......O...O.O....O......O.O.O",
            //    "...O......O....O....OOO.O.O..O..O.O......O...OO...O.O..O..O....O...O.....OOOOO..O.O...O..O...OO.O.OOO.O..O.O.OO..O.OO..O....O.OO.O.O..O....O.....O.O....OO.OO....OOO.OO.............OOO....",
            //    "..O.O.OOOOO.OO.O..O....O..O..O..O...O.OOO.OOO...O.O...O........O.O..OO.....O.O..O.......OOO.O......O.O..OO.O....O.O...O.OOO....OOO...O.O..O.O.OO..OOOOO.OO..O...OOO.......O.....O.O..O.O...",
            //    "O..OOO..OO.O....O.OO.O.O...O......OO.OO.O.O.......O....OO.OO...O....O......O...O.O..OO.....O....OOOOO.O.....O.OO....OOO.....OOO.O...OO..O.O..O.O......O..OOO.O..O...O.OOOO.O....O.O.O......",
            //    "O.O.O.OOO.....O......OOO.O..OOOOO......OO...O..O..O.OO.O.O..O...O...O.O...O...OOOO....O....OO....O...O......O.......O.O...OO.O....OO.OOO.O.O....O..O..OO.O..OOO.O.O..OO..OO...O...O...OO..O",
            //    ".OO..O.OO...O......O.O.O...OO.......O...O.O........O..............OOO.O..OO....O....OOO.OOOO....OO.O...OO...OO..OO.O..O......OO.O..O......OO.O........O.OO.OO.O....OO...OO.O.O..OO....OO..O",
            //    "O..O....O.OO.....O.O....O.OO...OO.OO...OO......OOO..............O.OOO.O..O.OO...OO...O.O......OOO...OO..OOO.OO....O.O.O.....O.......OOOO..O.O.....O....OO.O....O..OO..OOO...OOO..O.OO...OO.",
            //    "..OO.........O...........OO...OOO....O..O....O...O...O........O..O.O..OO.......OO...O.....O.O....O.OO.O..........O....OOO..OOO..O...O...O...O.O.OO...O.O..O....O...O...O.OO....O...OO..O.OO",
            //    "OO...OOO.OO...O.O...O...O....O........OOO....O..OO......O...O.O.O....OO....O..OO..O.....OO.............O...OOO....OOO.OO.....OO.........OO..O.O...OO.....O.OO.O.....O...OOO....O.....OO..O.",
            //    ".O....O.....O......O..O...O........O.O.O.OOO..OOO.OO.O...O..OOOOO......OOOO...O.O....O...OO........OO.....O..OO....O..O..OOOO..OOO....OO.......O..O.OOO.....OOO..OO......O.O....O.....O.OO.",
            //    ".......OOOOO.OOO....OO...O.O..OO...........O..O.O.OOOO.O..O.....O..O....O.......OOOO...O.......O...O.O.OO...O.....O.OOOO.OO.........OO.......OO....OOO...OO.O...O.O.O.........O.O....O..O..",
            //    "O...OO..O...O..O..O.O...O.O.O.O..OO.OOOOOOOO.O....O..O......O..O.O...O.O.....O......O..OO..OO...O.O...O..O..O...O...........O....O.OOOO.....O.O.O..OO.....O..OO....O........O.OOO.OOO...OOO",
            //    "OO.O.O.OOO.......O.O.OO.....O.O.........O..O..O...O..O.O........O....O.......O.....O......O......O.O..O.....OO..OO..O.O..O.........O.O.O...O...O..O..OO....O.OO......O...OO...O...OOO..O.O.",
            //    "OO...OO...O.OOO.......OO....O...OO.OOO..O......OO.O..OOO..O...O.O.O.OOO..O.......O....O.....O.O.O...O..OO..O.O..O.OOO.O.O....O.O...O.OO.O.OO.O.....O....OOO.......O..OO.....O...OOOO.O..OO.",
            //    ".O.O...O......OO..O....O....O.O.O..O..OO.O.....O.O.....OO..O..O...O....OO......O....O.O....OO.O.OO.O.OO............O..OOO.OO....OO..O.OO...O.....OOO......O.......OO.......O........O.....O",
            //    "..O..OO.O..O........O........O..OO..O........OOO.O.OOOO.....OO.OOO...OO...OO..O.O..........OO.O..O.....O.OO.O..O...OOOOOOO...O.......OO...O..O....O....O.......O..O.O.OOOO....O.O.OO..OO.O.",
            //    "O.....OO......O..OOO.O....OOO.......OO....O...OO...O...OO........O...O.OO...O.OOO..O........O......O.O...O.O..OOOOO.....OO...O.OOO........O.O...O..OOO..OO.....OO......O...O.OO.....OO.....",
            //    "O.O.O......O..O.O.O.OO....OO...OOO..O.......O.O.......OO..O.....O....OOO.O.............O.....O..O....O..OOO...O....O.....OO...OO.O.O...OOO..OO.O....O.......OO.O..O..OO.O..OOO.O..O.O.O.O..",
            //    "..........OOO.OO.OOO.....OOOO..OOO..O....O.O....OO.........OO......OOO.OOO..O...OOO.O.OO.OOOO.O..O.O.OOOO......O.OOOOOO...O.O....O.....OO..O.....O.O...O........O..OO..O.....OOOO...OOO..O.",
            //    "O.....O...O.OO.O.O.O..OO.O.OO.........O...O...O.O..OO.O.OOO.OO.O......O..OO.O..O.O..OOO...O.......O.....O...O...O.....O..........O..O.O...OOOO..OOO..O..OO.....O..OO.....OO...O..OO.....OO.",
            //    "....OO........O...OO.O.OO.O..O.OOO.O...OO.OOOO..O.O.O...O...OO.OO...OOO.......O........O...O..O..OO..OO.O...O.....O.O.O.O.......OOO.O..OO...O..O..OOO.OO..O........OO..O...O....OO..OO.O...",
            //    "O.....O....OO..O..O.OO..O...O..O.OO.O.O....O.O..O.O.......O...O.O..OOOO.OO...OOO..OOOO....OO...O..O......O....OO.O....O............O..O....O..OO..O..O.O.....O.....O....O....OO.....O....OO",
            //    "OO....O.O.O..O.O......OO..O..O..O...O..O...O....O.OO.O.OO.OO..O.....O...........OO......OO...OO.............O.....OO.O..OOO..O..OOO...O.O..O.O.O.O.........O..O.O.........OOO....OO..O.....",
            //    ".O.OO........O....O.OOOO..O.O..O.O...O.O...........O...OOO.O........O....O.O...O......O.OO...O....OO....O....OO..OO..O....OO.OO........OO....O......O.O.OO......OO............OO.O..O......",
            //    "....OO..OO..O......OOOOO.O....OO.....OO..O....OOOOOO.O...OOO...O....OO.O..O.O.......O.O.O..OO.O..............O..O...O.O...O....OOOO.O........O....OO..O.O.....O.O...O..O.O....O..O.....O...",
            //    "O.O..OO.O...O............OO.O....O.O........O...OOO.OO.O.......O...O.OO...O..O..O.....OO..............O......O...O..O..O.OO........OOO.O.OO.....O...OOO....O.OOO.OO.O..O.......OO........O.",
            //    ".OO.O...O.O.OOO.....O.O.OO.....O......OOO......O.O..O......O....OOO.O..O...O..O..O.OOOOO..O.....O...O....O....O..OOOO..OO..OO.......OO........O.O.O....O.O..O.O..OOO......O...O.......OO...",
            //    "......O..OO......O.O..O...O..O...O.O...OO....OO.O.O.....O..O...OO.....OO....O...........O.O...O.O..O...OO.O.O...OO.........O.O.O..........O....O.OO.OO....O..O..OO.O..O...O....O...OOO.....",
            //    ".......O...O...OO.O.....OO.O...O...O.OOOO...O....O.O.O..O......OO..O....OOO.O.OO......O..O...O..O.O............O.OO.O.OO.O.O..O..O......O.O..O....O...OOO.O......O...........O...O.O......O",
            //    "...O..O..O...O....O.OO.O.O.........O.OOOOO..O.O....OO....O..O....O.OO.OO..OO.OO..OO.....O.....OOOO.O.O.O.....O.O.OO..O.....O...O..O.OO.O...O.O....O.O.O..O..OO.......OO....O....OO.O..O.O..",
            //    "OOO...OO...O....OO.O..O.......O..O......OOOO..OO.OOOO.OO..O.OO........O...O.OO.O.OO....O.....O..O..OO.....OO.O.O.OOO....O.OOOOO.O..O...........OO.OO.OOOOOO....O..O...O.O.....O..O.O.O.OO.O",
            //    "...O..O..OO..O........OO....OO.....OO.......OO.OO....O.OO.....OO.OO....OO...O..O..OO.OOOOOOOO..O.......OO..O...O.O......OO.O..O....O.O......O....O......O...O....O....O...O.O..O.....OO.O.O",
            //    "O.O......O.O........O..O..O..O.O...OO........OO..OO..O..O.O.OO.OO.O..OO..O..O.OO.O.O.......O.....OOO....O.OO.OO..O...OO..O..O.OO..OOO.O...OOO..OO....O...O..O.OOOO..O.O....OO....O......O.O",
            //    ".O..O.OO.....O..O......O.O...O..OOOOO..O..OO.OO..OO...OO..O.OO.OO..O..OO.O..O.O.....O.O....OO......O..O.O..OOOO.O.......O.................O.......OOO..O....O...........O.....O...OO..O..O.",
            //    ".......O.O.O........O..O.OO....OO..O......OO......O.O...O.O.O........O.OO.......OO......O....OO......OOO.....OO..O...O.O.OO.O..OO....O..O.O.OO...OO......O....O...O.OOOO.OO.O...OOO....O.O.",
            //    ".............O.....O..O...O.OO.O.O....OO.OO....O.O.....O.O.O.....O...O..O...OO....OO...O.OO..OO..O.OO.OO.OO.O...O......O...O.......O...OO...O...O.O.O.....O....OO.O...O.OO....O..O.O.O....O",
            //    ".....O....O.O....O....OO....OOOOO............O..O..OO.O..O.O..O..OO.O....O..OO.O..O..O.....O..O..O..O.OO...O.O...O.OOO.............OO.........O..O.OO.....O..O.O..O.O..O.O....O.O.OO..OO.OO",
            //    ".....OO.OO.O.......O.O.OO...O...O.O....O.O.....O.O...O........O.OOO.O.O..O...OO..O..O..OOO...O.O.....O.....O..O..O..OOOO..O.OO.O....O..OO..OO.OOO.OO.OO.......O.........O.O..O.O..O..O...O.",
            //    ".O.OOO.OOO...O...OO.O..OO....O.O.O......O.O..O...........O.O......OO...O....O.....O.O...O.O........O..O.O..O.O...O.....O....O.O..O.OOO....O.OO..OO....O..O......O...O.....O.O.O.O..OO.OO.O.",
            //    ".OO....O....O.O..O...OO....O....O..OO.....O..O..O.OO.....OO...O..OOO.O.O....O...O..O...O.......O......O...........OO....O...O.O....O...O..OO..O.O..O.O....O..O......O..OO...O.O....O..OO...",
            //    "....OO..O..O....O.O...OO.O..O..O..O..O..O.O.O.....OOOOOOOO..O.....O.......OO...O.O...O.O...O.......O.....O.OO...O.O.O........OOO..OOO...........O.....O.OOO.OOOOO.O....O.OOOOO.....O..OO.O.",
            //    "O.....O..OO....O..O.....OO.O..O.O..O.OOO..OOO.....OO.OO..OOO...O.O.O...OO....O..O....O.O...OOO..O...OO......OOO....OO......OOO..O........O...........O.....O.....OOOO....OO....O..OOO...OO.",
            //    ".........O..O....OOOO.O.O...O.....O.........O...O.OO..O.......OO......O..O........O...O.......O.....O.OOO...O...O...O.O...O.OOO..OO.O.....OOO..O.O.O...O...O.O..O..O...O.O..O....OO.OO....O",
            //    "OO.O........OO.O.OO.O.O...O.......OO..OO..OO.O.O...O..OOO......O.....O.O.....O.......O.O..O.O....O.OO..O.O.O.O.O.......OOO.OOOOO..O..O....OO.....OO.......O.......O...O...O.OO..OOO.OO.OO..",
            //    "..OO.O..O...O.O...O..O.O..OO.....O......O.........O...O.....O........O..........O....O.....O.O....OOOOO.O...O......OO...O..O.O...OO.....OO...OO....O...............OOOO......O.O.OOO.......",
            //    ".OO...O......O.....OOO.O....O.O.O...OO..O.O.......O...O..OO......O.O..........O.O.O.O..O..OO.......O..O.........OO.O...OO....O.OOOO....O.....OO.O.O.....O.OO.........O.O.O.O.......OO......",
            //    "OO....O...O.O.O.....O..OO.O....O.OOOO.O..O..O..O......O.OO.O.OO..O....OOO.........OO.OO.O.O..O....OO...OOO.OOOOO....O.O.O.......O...OOOO.O...OO.O......O..OO.O..O......O.O..O..O.O..O..O...",
            //    ".O.O.O..O..OOO..OOOOOO.....O..O.O..OO.OO..O.O...O.O...O..OOO..O.......O..OO.O...O..........O.O.....O.....O..........OOO..OO.....O...O.O.O....O..OO.....O..OO.......O...O.....O.O...O.O.....",
            //    ".......O..O..O....OO.O..O..O.O.O.OO..O......O..OOO..O...O....OO....O.O...O......O...OO........O..O.O..OO..O.O...O...O..O.O.O.O..O.....O...........OO.O.O....O.O.OOO...O....OOOO..O..O.O.O.O",
            //    "..O...OOOO....O..OO.O.O..O...O....O.O.........OO..O.O.....O.O..OO.OOOOO....OO......O.O.OOOO.....O.......O...OOO....O.........OO.O.O......O.O...O.....OO...OO..O..O....OO..O.O.O.O.O.OO..O..",
            //    ".O....O....O....OO.O..OO...OO...O..O...........O..O.OO.............O......OOOO.O.O....O.......O........OOOOO.O......O.O.O..O..O....OO......OOO...O.O.........O..O...O..O.O.O....O.O..O.O..O",
            //    ".O.......OO..O.......O.OO.O..OO.....O........O..O...OO....O.O.OO.O.OO.OO...OOO.OO..OOO.........OO.OO....O.O.O.O..O.O.OO......O..O.O..O...O...O....O...O..O.O.O..O...OO...O.....OO.O.....O..",
            //    "...O......O.O....OO...O.OO.O.OO.OOOO.O.OO.......O.O.O....O..OO.O...O..OO......O..........O...O....O.OO..O.OOO.O......O.......O..O..O.......O.O...OO.O.......O...O..OOO.O.O...O.....O.......",
            //    ".....O.OOOOOOO.....O.....O.OO..OO......O.OO.O.OO..O...O.....O.O.OO.O...OO..OOO.O.O......O......OOOO.O.....O....OO......O......OO...O.O....O.....O.O.O.OOO.OO......OO.O........O.O..O.......",
            //    "O......OO...OO.............O....O.O..O.O.OO.O..O....OOO........O...OO..OOO...O..OO.O...OO.....O...OO........O.OOO..O..O.O.O.O...OO......O.O..O..O..OO.........OOO....OO.O.O...O.O..OOOO.O..",
            //    ".....O.O....OO...OOO..OO.O....O..O.....OO.......O.O......OOO.O..OOO..O.O...O..OO........O......OO..O.O..O............O..O.O......OO.OO...O.O........O....O......O.OO.O..O.OOOO...O.....OO..",
            //    ".O.....O.O.......O...O..O..O..O.O.O..OO...OO.O.O.......OO..OO..O.OOO.O..O..OO......O...OO.....O..O...O..O....OO.O.O...O............O...O.O.OO..OO...O.O.O...O..O...O.O......OO.............",
            //    "OOO....O..........O....OO.OOO....O..OO....O.OOO..OOO...O...O.O..OOO.....O.O.OOO....OO.O....O......O.OOO.OO..O.O......OO.O.OOO...O.O...OO......O...O...O........O..O....O......O..O.O.O.....",
            //    ".O.......O..O..O..OO....O.O.O...OO.OO..O.O.....O....O.O...OO.....O.OO...O.OO.OOO....OOO.OO.O.O......OO....OOO....O....OO.O.OO..O..............O....O.......OOOO.O.....O..OO.O...O.O...O....",
            //    "....OOO..O....OOO.O...OO..O.O.OOO.OO.O..O...O...OO....O.O.O.OO.......OOOO.O.....O..O......O...O...O.......O.OO....O.O..O....O..OO..O...O....OO...O....O.O.O.O......O...O.....OOOO.O...OO...",
            //    "OO...O.OOO.O........OOOO..O.O.........O...O..OO.O....O....O..OOO......OO.OO.O......OO....O...O....O...O.O.O..OOO............O.......O...OOOOO.....OO.OO.......O..O..O.OO.O...O.O...O..O.O..",
            //    ".O.....O.O..OOOO...OO...O.........O......O...OO...OO.OO..OOO.OO.....OO.O.O..O.O...O.O...OO..O..O...O.....OO..O...OOOO....O...O.O...O......O...OO.OO....O.OO.O.O.O......OOO..............OOO",
            //    ".OOO........O........OO.O..O..O.O.O.O....O.....O..OO.....O.....OOO......O....OO.O..........O...O.....O..O......O..O........O.O..OO...OO..OOOO.......O.O.O...O.OO..OO..O....O...OOOO.OOO.O..",
            //    "..O.O.........O..O....O.......O..O......O...O......O..O......O.O...O.....O.O...O..O.O...O.O...OO..O.....O..O.O..OOO..OOO.........O.....OO...OO.O...OO..O...OOO....OO.OOO..O.......O.....O.O",
            //    "O......OO.O..OO...O........O.O......O.O.OOOOO.....O.O..O.OO........OOOOOO..OOOO.O..OO..O...O....OOO...OO.O.O.O...O...O...OO...O..O..O......OO.....OO.O.O.OOO.O...OO...O..OOOOOOOO.O.OO.OO..",
            //    "...O..O..O..OO..O.OO..OO.O.......OO...OO.OO...O..OO..OOO...OO.O....O....O......O..O..OO...O.........OO.O.OO.O...OO..O..O....O.O.......O.O..O...O.O.O.OOO.O......OO....O.O......O....OO.O.OO",
            //    "............O.OO.OO....O...OO.O....O....O............O...OO....O..O...........OO.O......OO...OO...O.OO.OO..O.O...O..O......O.O.O....O....O..O....O.....O...................O.....OO..O.O...",
            //    ".O...O......OO.OOO.O....O...O....O..O...O..OOO.....O..OO..O.OO...........O...O....OO.....O....O.O.......OO..O..O..O...O.......OOOO.O....OO..O..O.....O.O...O.O.OO....O...OOOO.......O..O.OO",
            //    "....O..O....O...OO...O......OO..O.OOOO...O.O..O.O.....OOOO..O...O.OO....O.O.....OOO.OO..OOOO.OO.OOO..O.....OO..O.O.......OOO.......O...O........O..OOOO.O.....O..OO.O..OO.......OOO.OO....O",
            //    ".......OO..OOO.O..OOO.O........O..O.O.O.........O.OO.....OO..O.OO.....O..O..O..O.......OO..O.O.O.....O...O.....O..O..O.....O.O.O..O..O..OOOO.....OOOOO..O..O......OOO..O.OO...O..O.OOOO..OO",
            //    ".O.....O........OOO..OO.....O......OO.O.OO......O.O.........OO.....OO...O.......O.....OO..O..O...OO.O........O....O....O.O..O...OO........OOO.OO.....OO..O.OO...OO.O..OOO.OO...O....O......",
            //    "...O.O..OOO...O.....OO..O....O....O..O.O...OO....O...O.O.O..O.O....O.O.O.....O............OO.O......O..OO........OO..OO........O.OO.O...O.O......O...OOOO.O..O..O...O..OOO.O.......O.OOO..O",
            //    "O..O......O...O..O.O.O....OO.O..O..OO..OOOOO....O...O........O.O..OOO..O.O.OOO.........OO...O..O......O.O.OO..O...OOO.....O........O.OOO.....O...O..O.O...O.O...O.OO.......OO.O.......O..OO",
            //    "..OOO..O...O.O..OO......OO..O.....O.OO.OOOOO....OOO.O..O.O......OO...O......O.OOO.....OOO....O.........O..O...............O....OO..O....O.....OO....OO....O......O..OO..O.OO....O.....O.O.O",
            //    "....O......O....O......O...O.O.....OOOOOO..O...O.O.........O......O.O..O.O...O...O.O..O.......O.O...O..OO..O....O...O.O....O.OO.....O..OO....O.......OOO..O.OOO...OOO...O....O...O.O.......",
            //    "O..OO.....O.O.OOO..OO..O.O...O..O.....O...O.O..O....OO..OO..O.OOO.O.OO.OO...O.......O...O..OO.OO.O.O.....O....O....OO....O.OOOO.O....O.OO......OO.O.......O.OO.....O..O...O....O.........O.",
            //    "..O..O...O..O.O...OO.O..O....O.O.OOOOO...O.....OOO..O.O..O.........OOO....O..O..........O..............O..O.O....OO.....O.OO.OOO.....O...........O...O...O..O....O.O.....O.OOO....O...O....",
            //    ".OO.O....OO.OO..O.OOO....OO...O.OO.O.....O.OO..OO.O...O....O...O.OO..O....O.O...O..O..O..O.O.O........OOOO.O..OO....O.....OO...O..O.......OO.O.OO.OO..OO.........O..O.OO....O........OO...O",
            //    "OOOO.O......OOOO.O.OOO..O......O.O.O..OOOOOO.OOO.......O..OO.O...O..O..O...O.......O.OO.....O...O.....OOO.O...OO.....OO.......O..O.O......O..O.O..O.OOO..OOO..O..O.OOOOO..O...O.O...OO.O..."
            //};

            //string[] inp = new string[]
            //{
            //    ".......",
            //    "...O...",
            //    "....O..",
            //    ".......",
            //    "OO.....",
            //    "OO....."
            //};

            string[] inp = new string[]
            {
                "O..O",
                ".O..",
                "...."
            };

            var now = DateTime.Now;

            var convertedArr = inp.Select(x => x.ToCharArray()).ToArray();

            var result = GridAfterSeconds(GridAfterSeconds(convertedArr));

            for (var i = 0; i < result.Length; i++)
            {
                Console.WriteLine(string.Join("", result[i]));
            }

            Console.WriteLine("done " + (DateTime.Now - now));
        }

        static char[][] GridAfterSeconds(char[][] grid)
        {
            var boomIndexes = new List<int[]>();

            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                {
                    if (grid[i][j] == 'O')
                    {
                        boomIndexes.Add(new int[] { i, j });
                    }
                }
            }

            var result = new char[grid.Length][];

            for (int i = 0; i < grid.Length; i++)
            {
                result[i] = new char[grid[i].Length];
                for (int j = 0; j < grid[i].Length; j++)
                {
                    result[i][j] = 'O';
                }
            }

            foreach (var boomIdx in boomIndexes)
            {
                result[boomIdx[0]][boomIdx[1]] = '.';
                if (boomIdx[0] > 0)
                {
                    result[boomIdx[0] - 1][boomIdx[1]] = '.';
                }
                if (boomIdx[0] < result.Length - 1)
                {
                    result[boomIdx[0] + 1][boomIdx[1]] = '.';
                }
                if (boomIdx[1] > 0)
                {
                    result[boomIdx[0]][boomIdx[1] - 1] = '.';
                }
                if (boomIdx[1] < result[0].Length - 1)
                {
                    result[boomIdx[0]][boomIdx[1] + 1] = '.';
                }
            }

            return result;
        }

    }
}