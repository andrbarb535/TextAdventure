/// created by : Andrew Barber
/// date       : 2018-11-09
/// description: A basic text adventure game engine
/// message    : outputLabel.Text += "C\nrb\ney\na.\nt.\ne.\nd.\nA.\nn.\ndB\nra\ner\nwb\n.e\n.r";

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace LostV2
{
    public partial class Form1 : Form
    {
        // tracks what part of the game the user is at
        int scene = 0;

        // race
        string r;

        // sub-race
        string sR;

        // draconic ancestry
        string dA;

        // class
        string c;

        // random number generator
        Random randGen = new Random();

        public Form1()
        {
            InitializeComponent();

            //display initial message
            titleLabel.Text = "Create a character";

            //display initial message
            outputLabel.Text = "Start by choosing a race";

            //options
            redButtonLabel.Visible = true;
            redLabel.Visible = true;
            redLabel.Text = "Dwarf";

            orangeRedButtonLabel.Visible = true;
            orangeRedLabel.Visible = true;
            orangeRedLabel.Text = "Elf";

            orangeButtonLabel.Visible = true;
            orangeLabel.Visible = true;
            orangeLabel.Text = "Halfling";

            orangeYellowButtonLabel.Visible = true;
            orangeYellowLabel.Visible = true;
            orangeYellowLabel.Text = "Human";

            yellowButtonLabel.Visible = true;
            yellowLabel.Visible = true;
            yellowLabel.Text = "Dragonborn";

            lemonYellowButtonLabel.Visible = true;
            lemonYellowLabel.Visible = true;
            lemonYellowLabel.Text = "Gnome";

            yellowGreenButtonLabel.Visible = true;
            yellowGreenLabel.Visible = true;
            yellowGreenLabel.Text = "Half-Elf";

            sapGreenButtonLabel.Visible = true;
            sapGreenLabel.Visible = true;
            sapGreenLabel.Text = "Half-Orc";

            greenButtonLabel.Visible = true;
            greenLabel.Visible = true;
            greenLabel.Text = "Tiefling";

            bluishGreenButtonLabel.Visible = false;
            bluishGreenLabel.Visible = false;

            turquoiseButtonLabel.Visible = false;
            turquoiseLabel.Visible = false;

            greenishCyanButtonLabel.Visible = false;
            greenishCyanLabel.Visible = false;

            cyanBlueButtonLabel.Visible = false;
            cyanBlueLabel.Visible = false;

            bluishCyanButtonLabel.Visible = false;
            bluishCyanLabel.Visible = false;

            blueButtonLabel.Visible = false;
            blueLabel.Visible = false;

            blueVioletButtonLabel.Visible = false;
            blueVioletLabel.Visible = false;

            violetButtonLabel.Visible = false;
            violetLabel.Visible = false;

            purpleVioletButtonLabel.Visible = false;
            purpleVioletLabel.Visible = false;

            purpleButtonLabel.Visible = false;
            purpleLabel.Visible = false;

            purpleMagentsButtonLabel.Visible = false;
            purpleMagentaLabel.Visible = false;

            magentaButtonLabel.Visible = false;
            magentaLabel.Visible = false;

            crimsonButtonLabel.Visible = false;
            crimsonLabel.Visible = false;

            scarletButtonLabel.Visible = false;
            scarletLabel.Visible = false;

            scarletRedButtonLabel.Visible = false;
            scarletRedLabel.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            /// check to see what button has been pressed and advance
            /// to the next appropriate scene
            if (e.KeyCode == Keys.A)       //red button press
            {
                if (scene == 0)
                {
                    scene = 1;
                    r = "Dwarf";
                }
                else if (scene == 1)
                {
                    scene = 6;
                    sR = "Hill Dwarf";
                }
                else if (scene == 2)
                {
                    scene = 6;
                    sR = "High Elf";
                }
                else if (scene == 3)
                {
                    scene = 6;
                    sR = "Lightfoot";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Black";
                }
                else if (scene == 5)
                {
                    scene = 6;
                    sR = "Forest Gnome";
                }
                else if (scene == 6)
                {
                    scene = 7;
                    c = "Barbarian";
                }
                else if (scene == 7)
                {
                    scene = 9;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 99;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 11)
                {
                    scene = 13;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 99;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 20;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if (scene == 21)
                {
                    scene = 23;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 99;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 27;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 30)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 99;
                }
                else if (scene == 32)
                {
                    scene = 34;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 34)
                {
                    scene = 99;
                }
                else if (scene == 35)
                {
                    scene = 36;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 39)
                {
                    scene = 41;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 41)
                {
                    scene = 99;
                }
                else if (scene == 42)
                {
                    scene = 43;
                }
                else if (scene == 43)
                {
                    scene = 46;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 46)
                {
                    scene = 99;
                }
                else if (scene == 47)
                {
                    scene = 48;
                }
                else if (scene == 48)
                {
                    scene = 49;
                }
                else if (scene == 49)
                {
                    scene = 99;
                }
                else if (scene == 50)
                {
                    scene = 52;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 52)
                {
                    scene = 53;
                }
                else if (scene == 53)
                {
                    scene = 99;
                }
                else if (scene == 54)
                {
                    scene = 56;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 56)
                {
                    scene = 57;
                }
                else if (scene == 57)
                {
                    scene = 58;
                }
                else if (scene == 58)
                {
                    scene = 59;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
                else if (scene == 60)
                {
                    scene = 61;
                }
                else if (scene == 61)
                {
                    scene = 62;
                }
                else if (scene == 62)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.B)  //orange red button press
            {
                if (scene == 0)
                {
                    scene = 2;
                    r = "Elf";
                }
                else if (scene == 1)
                {
                    scene = 6;
                    sR = "Mountain Dwarf";
                }
                else if (scene == 2)
                {
                    scene = 6;
                    sR = "Wood Elf";
                }
                else if (scene == 3)
                {
                    scene = 6;
                    sR = "Stout";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Blue";
                }
                else if (scene == 5)
                {
                    scene = 6;
                    sR = "Rock Gnome";
                }
                else if (scene == 6)
                {
                    scene = 11;
                    c = "Bard";
                }
                else if (scene == 7)
                {
                    scene = 8;
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 9)
                {
                    scene = 10;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 11)
                {
                    scene = 13;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 13)
                {
                    scene = 14;
                }
                else if (scene == 14)
                {
                    scene = 15;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 16)
                {
                    scene = 17;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 18)
                {
                    scene = 19;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 20)
                {
                    scene = 99;
                }
                else if (scene == 21)
                {
                    scene = 22;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 23)
                {
                    scene = 24;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 26)
                {
                    scene = 28;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 30)
                {
                    scene = 31;
                }
                else if (scene == 31)
                {
                    scene = 99;
                }
                else if (scene == 32)
                {
                    scene = 33;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 34)
                {
                    scene = 99;
                }
                else if (scene == 35)
                {
                    scene = 37; 
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 39)
                {
                    scene = 40;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 41)
                {
                    scene = 99;
                }
                else if (scene == 42)
                {
                    scene = 43;
                }
                else if (scene == 43)
                {
                    scene = 44;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 46)
                {
                    scene = 99;
                }
                else if (scene == 47)
                {
                    scene = 48;
                }
                else if (scene == 48)
                {
                    scene = 49;
                }
                else if (scene == 49)
                {
                    scene = 99;
                }
                else if (scene == 50)
                {
                    scene = 51;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 52)
                {
                    scene = 53;
                }
                else if (scene == 53)
                {
                    scene = 99;
                }
                else if (scene == 54)
                {
                    scene = 55;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 56)
                {
                    scene = 57;
                }
                else if (scene == 57)
                {
                    scene = 58;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
                else if (scene == 60)
                {
                    scene = 61;
                }
                else if (scene == 61)
                {
                    scene = 62;
                }
                else if (scene == 62)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.C)  //orange button press
            {
                if (scene == 0)
                {
                    scene = 3;
                    r = "Halfling";
                }
                else if (scene == 2)
                {
                    scene = 6;
                    sR = "Dark Elf";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Brass";
                }
                else if (scene == 5)
                {
                    scene = 6;
                    sR = "Deep Gnome";
                }
                else if (scene == 6)
                {
                    scene = 16;
                    c = "Cleric";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 11)
                {
                    scene = 12;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 17)
                {
                    scene = 18;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 25)
                {
                    scene = 26;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 49)
                {
                    scene = 99;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.D)  //orange yellow button press
            {
                if (scene == 0)
                {
                    scene = 6;
                    r = "Human";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Bronze";
                }
                else if (scene == 6)
                {
                    scene = 21;
                    c = "Druid";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.E)  //yellow button press
            {
                if (scene == 0)
                {
                    scene = 4;
                    r = "Dragonborn";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Copper";
                }
                else if (scene == 6)
                {
                    scene = 25;
                    c = "Fighter";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.F)  //lemon yellow button press
            {
                if (scene == 0)
                {
                    scene = 5;
                    r = "Gnome";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Gold";
                }
                else if (scene == 6)
                {
                    scene = 32;
                    c = "Monk";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.G)  //yellow green button press
            {
                if (scene == 0)
                {
                    scene = 6;
                    r = "Half-Elf";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Green";
                }
                else if (scene == 6)
                {
                    scene = 35;
                    c = "Paladin";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.H)  //sap green button press
            {
                if (scene == 0)
                {
                    scene = 6;
                    r = "Half-Orc";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Red";
                }
                else if (scene == 6)
                {
                    scene = 42;
                    c = "Ranger";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.I)  //green button press
            {
                if (scene == 0)
                {
                    scene = 6;
                    r = "Tiefling";
                }
                else if (scene == 4)
                {
                    scene = 6;
                    dA = "Silver";
                }
                else if (scene == 6)
                {
                    scene = 47;
                    c = "Rogue";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.J)  //bluish green button press
            {
                if (scene == 4)
                {
                    scene = 6;
                    dA = "White";
                }
                else if (scene == 6)
                {
                    scene = 50;
                    c = "Sorcerer";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 10)
                {
                    scene = 99;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 15)
                {
                    scene = 99;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 24)
                {
                    scene = 99;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 40)
                {
                    scene = 41;
                }
                else if (scene == 44)
                {
                    scene = 45;
                }
                else if (scene == 45)
                {
                    scene = 46;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.K)  //turquoise button press
            {
                if (scene == 6)
                {
                    scene = 54;
                    c = "Warlock";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.L)  //greenish cyan button press
            {
                if (scene == 6)
                {
                    scene = 60;
                    c = "Wizard";
                }
                else if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.M)  //cyan blue button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.N)  //bluish cyan button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 12)
                {
                    scene = 13;
                }
                else if (scene == 19)
                {
                    scene = 20;
                }
                else if (scene == 22)
                {
                    scene = 23;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 33)
                {
                    scene = 34;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
                else if (scene == 51)
                {
                    scene = 52;
                }
                else if (scene == 55)
                {
                    scene = 56;
                }
                else if (scene == 59)
                {
                    scene = 99;
                }
            }
            else if (e.KeyCode == Keys.O)  //blue button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.P)  //blue violet button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.Q)  //violet button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.R)  //purple violet button press
            {
                if (scene == 8)
                {
                    scene = 9;
                }
                else if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.S)  //purple button press
            {
                if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.T)  //purple magenta button press
            {
                if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.U)  //magenta button press
            {
                if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.V)  //crimson button press
            {
                if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.W)  //scarlet button press
            {
                if (scene == 27)
                {
                    scene = 30;
                }
                else if (scene == 28)
                {
                    scene = 29;
                }
                else if (scene == 29)
                {
                    scene = 30;
                }
                else if (scene == 36)
                {
                    scene = 39;
                }
                else if (scene == 37)
                {
                    scene = 39;
                }
                else if (scene == 38)
                {
                    scene = 39;
                }
            }
            else if (e.KeyCode == Keys.X)  //scarlet red button press
            {

            }

            /// Display text and game options to screen based on the current scene
            switch (scene)
            {
                case 0:  //start scene
                         //display initial message
                    titleLabel.Text = "Create a character";

                    //display initial message
                    outputLabel.Text = "Start by choosing a race";
                    outputLabel.Text = "Start by choosing a race";
                    outputLabel.Text = "Start by choosing a race";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Dwarf";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Elf";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Halfling";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Human";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Dragonborn";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Gnome";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Half-Elf";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Half-Orc";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Tiefling";

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 1:
                    //display initial message
                    outputLabel.Text = "Choose a sub-race";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Hill Dwarf";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Mountain Dwarf";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 2:
                    //display initial message
                    outputLabel.Text = "Choose a sub-race";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "High Elf";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Wood Elf";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Dark Elf";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 3:
                    //display initial message
                    outputLabel.Text = "Choose a sub-race";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Lightfoot";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Stout";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 4:
                    //display initial message
                    outputLabel.Text = "Choose a draconic ancestry";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Black";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Blue";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Brass";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Bronze";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Copper";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Gold";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Green";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Red";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Silver";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "White";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 5:
                    //display initial message
                    outputLabel.Text = "Choose a sub-race";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Forest Gnome";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Rock Gnome";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Deep Gnome";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 6:
                    //display initial message
                    outputLabel.Text = "Choose a class";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Barbarian";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Bard";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Cleric";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Druid";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Fighter";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Monk";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Paladin";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Ranger";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Rogue";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Sorcerer";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Warlock";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Wizard";

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 7:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Greataxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Martial Melee Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 8:
                    //display initial message
                    outputLabel.Text = "Choose a martial melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 9:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Two Handaxes";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Melee Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 10:
                    //display initial message
                    outputLabel.Text = "Choose a simple melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 11:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment"; 

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Rapier";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Longsword";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Any Simple Weapon";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 12:
                    //display initial message
                    outputLabel.Text = "Choose a simple weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 13:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Diplomats Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Entertainers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 14:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Lute";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Musical Instrument";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 15:
                    //display initial message
                    outputLabel.Text = "Choose a musical instrument";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Bagpipes";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Drum";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Dulcimer";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Flute";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Lute";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Lyre";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Horn";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Pan Flute";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Shawm";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Viol";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 16:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Mace";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Warhammer";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 17:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Scale Mail";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Leather Armor";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Chain Mail";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 18:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Light Crossbow";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 19:
                    //display initial message
                    outputLabel.Text = "Choose a Simple Weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";
 
                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 20:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Priests Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 21:
                    //display initial message
                    outputLabel.Text = "Chppse starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Wooden Shield";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 22:
                    //display initial message
                    outputLabel.Text = "Choose a Simple Weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 23:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Scimitar";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Melee Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 24:
                    //display initial message
                    outputLabel.Text = "Choose a simple melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 25:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Chain Mail";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Leather Armor";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Longbow";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 26:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Any Martial Weapon and a Shield";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Two Martial Weapons";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 27:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip"; 

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 28:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 29:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 30:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Light Crossbow";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Two Handaxes";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 31:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Dungeoneers Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 32:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Shortsword";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 33:
                    //display initial message
                    outputLabel.Text = "Choose a simple weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 34:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Dungeoneers Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 35:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Any Martial Weapon and a Shield";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Two Martial Weapons";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 36:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 37:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 38:
                    //display initial message
                    outputLabel.Text = "Choose a martial weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Battleaxe";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Flail";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Glaive";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Greataxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Greatsword";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Halberd";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Lance";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Longsword";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Maul";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Morningstar";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Pike";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Rapier";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Scimitar";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Shortsword";

                    blueButtonLabel.Visible = true;
                    blueLabel.Visible = true;
                    blueLabel.Text = "Trident";

                    blueVioletButtonLabel.Visible = true;
                    blueVioletLabel.Visible = true;
                    blueVioletLabel.Text = "War Pick";

                    violetButtonLabel.Visible = true;
                    violetLabel.Visible = true;
                    violetLabel.Text = "Warhammer";

                    purpleVioletButtonLabel.Visible = true;
                    purpleVioletLabel.Visible = true;
                    purpleVioletLabel.Text = "Whip";

                    purpleButtonLabel.Visible = true;
                    purpleLabel.Visible = true;
                    purpleLabel.Text = "Blowgun";

                    purpleMagentsButtonLabel.Visible = true;
                    purpleMagentaLabel.Visible = true;
                    purpleMagentaLabel.Text = "Hand Crossbow";

                    magentaButtonLabel.Visible = true;
                    magentaLabel.Visible = true;
                    magentaLabel.Text = "Heavy Crossbow";

                    crimsonButtonLabel.Visible = true;
                    crimsonLabel.Visible = true;
                    crimsonLabel.Text = "Longbow";

                    scarletButtonLabel.Visible = true;
                    scarletLabel.Visible = true;
                    scarletLabel.Text = "Net";

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 39:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Five Javelins";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Melee Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 40:
                    //display initial message
                    outputLabel.Text = "Choose a simple melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 41:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Priests Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 42:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Scale Mail";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Leather Armor";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 43:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Two Shortswords";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Two Simple Melee Weapons";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 44:
                    //display initial message
                    outputLabel.Text = "Choose a simple melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 45:
                    //display initial message
                    outputLabel.Text = "Choose a simple melee weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 46:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Dungeoneers Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 47:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Rapier";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Shortsword";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 48:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Shortbow";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Shortsword";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 49:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Burglars Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dungeoneers Pack";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Explorers Pack";

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 50:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Light Crossbow";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 51:
                    //display initial message
                    outputLabel.Text = "Choose a simple weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 52:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Component Pouch";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Arcane Focus";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 53:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Dungeoneers Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Explorers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 54:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Light Crossbow";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Any Simple Weapon";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 55:
                    //display initial message
                    outputLabel.Text = "Choose a simple weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 56:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Component Pouch";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Arcane Focus";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 57:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Scholars Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dungeoneers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 58:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Any Simple Weapon";

                    orangeRedButtonLabel.Visible = false;
                    orangeRedLabel.Visible = false;

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 59:
                    //display initial message
                    outputLabel.Text = "Choose a simple weapon";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Club";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = true;
                    orangeLabel.Visible = true;
                    orangeLabel.Text = "Greatclub";

                    orangeYellowButtonLabel.Visible = true;
                    orangeYellowLabel.Visible = true;
                    orangeYellowLabel.Text = "Handaxe";

                    yellowButtonLabel.Visible = true;
                    yellowLabel.Visible = true;
                    yellowLabel.Text = "Javelin";

                    lemonYellowButtonLabel.Visible = true;
                    lemonYellowLabel.Visible = true;
                    lemonYellowLabel.Text = "Light Hammer";

                    yellowGreenButtonLabel.Visible = true;
                    yellowGreenLabel.Visible = true;
                    yellowGreenLabel.Text = "Mace";

                    sapGreenButtonLabel.Visible = true;
                    sapGreenLabel.Visible = true;
                    sapGreenLabel.Text = "Quarterstaff";

                    greenButtonLabel.Visible = true;
                    greenLabel.Visible = true;
                    greenLabel.Text = "Sickle";

                    bluishGreenButtonLabel.Visible = true;
                    bluishGreenLabel.Visible = true;
                    bluishGreenLabel.Text = "Spear";

                    turquoiseButtonLabel.Visible = true;
                    turquoiseLabel.Visible = true;
                    turquoiseLabel.Text = "Light Crossbow";

                    greenishCyanButtonLabel.Visible = true;
                    greenishCyanLabel.Visible = true;
                    greenishCyanLabel.Text = "Dart";

                    cyanBlueButtonLabel.Visible = true;
                    cyanBlueLabel.Visible = true;
                    cyanBlueLabel.Text = "Shortbow";

                    bluishCyanButtonLabel.Visible = true;
                    bluishCyanLabel.Visible = true;
                    bluishCyanLabel.Text = "Sling";

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 60:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Quarterstaff";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dagger";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 61:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Component Pouch";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible =  true;
                    orangeRedLabel.Text = "Arcane Focus";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 62:
                    //display initial message
                    outputLabel.Text = "Choose starting equipment";

                    //options
                    redButtonLabel.Visible = true;
                    redLabel.Visible = true;
                    redLabel.Text = "Scholars Pack";

                    orangeRedButtonLabel.Visible = true;
                    orangeRedLabel.Visible = true;
                    orangeRedLabel.Text = "Dungeoneers Pack";

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                case 99:
                    //display initial message
                    titleLabel.Text = "This is your character";
                    outputLabel.Text = "Race: " + r + "\n\nSub-Race: " + sR + "\n\nDraconic Ancestry: " + dA + "\n\nClass: " + c;

                    //options
                    redButtonLabel.Visible = false;
                    redLabel.Visible = false;

                    orangeRedButtonLabel.Visible = false;
                    orangeRedLabel.Visible = false;

                    orangeButtonLabel.Visible = false;
                    orangeLabel.Visible = false;

                    orangeYellowButtonLabel.Visible = false;
                    orangeYellowLabel.Visible = false;

                    yellowButtonLabel.Visible = false;
                    yellowLabel.Visible = false;

                    lemonYellowButtonLabel.Visible = false;
                    lemonYellowLabel.Visible = false;

                    yellowGreenButtonLabel.Visible = false;
                    yellowGreenLabel.Visible = false;

                    sapGreenButtonLabel.Visible = false;
                    sapGreenLabel.Visible = false;

                    greenButtonLabel.Visible = false;
                    greenLabel.Visible = false;

                    bluishGreenButtonLabel.Visible = false;
                    bluishGreenLabel.Visible = false;

                    turquoiseButtonLabel.Visible = false;
                    turquoiseLabel.Visible = false;

                    greenishCyanButtonLabel.Visible = false;
                    greenishCyanLabel.Visible = false;

                    cyanBlueButtonLabel.Visible = false;
                    cyanBlueLabel.Visible = false;

                    bluishCyanButtonLabel.Visible = false;
                    bluishCyanLabel.Visible = false;

                    blueButtonLabel.Visible = false;
                    blueLabel.Visible = false;

                    blueVioletButtonLabel.Visible = false;
                    blueVioletLabel.Visible = false;

                    violetButtonLabel.Visible = false;
                    violetLabel.Visible = false;

                    purpleVioletButtonLabel.Visible = false;
                    purpleVioletLabel.Visible = false;

                    purpleButtonLabel.Visible = false;
                    purpleLabel.Visible = false;

                    purpleMagentsButtonLabel.Visible = false;
                    purpleMagentaLabel.Visible = false;

                    magentaButtonLabel.Visible = false;
                    magentaLabel.Visible = false;

                    crimsonButtonLabel.Visible = false;
                    crimsonLabel.Visible = false;

                    scarletButtonLabel.Visible = false;
                    scarletLabel.Visible = false;

                    scarletRedButtonLabel.Visible = false;
                    scarletRedLabel.Visible = false;
                    break;
                default:
                    break;
            }
        }
    }
}
