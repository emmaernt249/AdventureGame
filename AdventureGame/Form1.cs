using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace AdventureGame
{
    public partial class Form1 : Form
    {
        int scene = 0;

        public Form1()
        {
            InitializeComponent();
            //display initial message and options
            //SoundPlayer forestPlayer = new SoundPlayer(Properties.Resources.jungle);
            outputLabel.Text = "you find yourself lost in a jungle. You can't find where you came from. Go to north, east or west of you?";
            RedLabel.Text = "go east";
            BlueLabel.Text = "go north";
            YellowLabel.Text = "go west";

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            //red button
            if (e.KeyCode == Keys.M)       //red button press, east (finished) m button
            {
                if (scene == 0) { scene = 1; }
                else if (scene == 1) { scene = 2; }
                else if (scene == 2) { scene = 5; }
                else if (scene == 2) { scene = 6; }
                else if (scene == 5) { scene = 10; }
                else if (scene == 5) { scene = 11; }
                else if (scene == 10) { scene = 16; }
                else if (scene == 10) { scene = 17; }

                //death and success messages are spaced
                else if (scene == 6) { scene = 11; }

                else if (scene == 11) { scene = 22; }

                else if (scene == 14) { scene = 21; }

                else if (scene == 15) { scene = 22; }

                else if (scene == 16) { scene = 20; }

                else if (scene == 17) { scene = 22; }

                else if (scene == 18) { scene = 22; }

                else if (scene == 19) { scene = 22; }
            }
            else if (e.KeyCode == Keys.B)  //blue button press, north (finished) b button 
            {
                if (scene == 0) { scene = 3; }
                else if (scene == 3) { scene = 7; }
                else if (scene == 3) { scene = 8; }
                else if (scene == 7) { scene = 12; }
                else if (scene == 7) { scene = 14; }
                else if (scene == 12) { scene = 13; }
                else if (scene == 12) { scene = 18; }
                else if (scene == 13) { scene = 19; }
                else if (scene == 13) { scene = 8; }
                else if (scene == 8) { scene = 14; }

                else if (scene == 6) { scene = 11; }

                else if (scene == 11) { scene = 22; }

                else if (scene == 14) { scene = 21; }

                else if (scene == 15) { scene = 22; }

                else if (scene == 16) { scene = 20; }

                else if (scene == 17) { scene = 22; }

                else if (scene == 18) { scene = 22; }

                else if (scene == 19) { scene = 22; }
            }
            else if (e.KeyCode == Keys.N)  //yellow button press, west (finished) n button
            {
                if (scene == 0) { scene = 4; }
                else if (scene == 4) { scene = 0; }
                else if (scene == 4) { scene = 9; }
                else if (scene == 9) { scene = 15; }

                else if (scene == 6) { scene = 11; }

                else if (scene == 11) { scene = 22; }

                else if (scene == 14) { scene = 21; }

                else if (scene == 15) { scene = 22; }

                else if (scene == 16) { scene = 20; }

                else if (scene == 17) { scene = 22; }

                else if (scene == 18) { scene = 22; }

                else if (scene == 19) { scene = 22; }
            }

            switch (scene)
            {

                case 0:  //start scene  
                   
                   // SoundPlayer forestPlayer = new SoundPlayer(Properties.Resources.jungle);
                    outputLabel.Text = "you find yourself lost in a jungle. You can't find where you came from. Go to north, east or west of you?";
                    RedLabel.Text = "go north";
                    BlueLabel.Text = "go south";
                    YellowLabel.Text = "go west";
                    sceneImage.BackgroundImage = Properties.Resources.jungle; 
                    break;
                case 2:
                    outputLabel.Text = "you're now in a foggy and thin forest. You hear people in the distance. follow what seems to be people or proceed to walk your path?";
                    RedLabel.Text = "follow";
                    BlueLabel.Text = "proceed";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.foggyForest;
                    break;
                case 3:
                    outputLabel.Text = "you find a clearing. You find something sprinting in the tall grass. Proceed or continue the path?";
                    RedLabel.Text = "proceed";
                    BlueLabel.Text = "continue";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.grass;
                    break;
                case 4:
                    outputLabel.Text = "you find yourself only going deeper into the forest.You shiver. It's cold. you hear a low growl in a distance. proceed to walk, or go back?";
                    RedLabel.Text = "proceed";
                    BlueLabel.Text = "go back";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.DeepForest;
                    break;
                case 5:
                    outputLabel.Text = "you found people! but they have a strange appearance. Do you talk to them, or run away from fear ?";
                    RedLabel.Text = "talk to them";
                    BlueLabel.Text = "run away";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.MysteryPeople;
                    break;
                case 6:
                    outputLabel.Text = "You have a really bad migraine, and all your natural senses seem to fled away from you. You then feel light headed and pass out.";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 7:
                    outputLabel.Text = "You found a dog. do you pet it or ignore it and walk northwest?";
                    RedLabel.Text = "pet it";
                    BlueLabel.Text = "walk northwest";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.foggyForest;
                    break;
                case 8:
                    outputLabel.Text = "you recognize this river. do you follow the path of the river, or do you cross it ?";
                    RedLabel.Text = "follow";
                    BlueLabel.Text = "cross it";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.jungleRiverFinish;
                    break;
                case 9:
                    outputLabel.Text = "Suddenly, a tiger comes out of the bushes and growls at you. Do you run away, or play dead?";
                    RedLabel.Text = "run away";
                    BlueLabel.Text = "play dead";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.foggyForest;
                    break;
                case 10:
                    outputLabel.Text = "they ask you if you're lost, and if you need shelter for a night. say you're fine or you're in need of shelter?";
                    RedLabel.Text = "I'm fine";
                    BlueLabel.Text = "I need shelter";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.MysteryPeople;
                    break;
                case 11:
                    outputLabel.Text = "you died from something you didn't know about. Gas was sprayed around the area recently.";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 12:
                    outputLabel.Text = "the dog follows you. you realize the dog has a bit of a limp, and you feel bad, wanting to get home as soon as possible. Any more of this, and you might go insane. go northwest with it, or keep going?";
                    RedLabel.Text = "northwest";
                    BlueLabel.Text = "keep going";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.grass;
                    sceneImage.BackgroundImage = Properties.Resources.dog;
                    break;
                case 13:
                    outputLabel.Text = "you've found a major road near your city. do you try to cross it, or do you want to follow it?";
                    RedLabel.Text = "cross";
                    BlueLabel.Text = "follow";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Forest_road;
                    break;
                case 14:
                    outputLabel.Text = "You found the city you live in! You won the game, congratulations!";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 15:
                    outputLabel.Text = "You died from bleeding to death!";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 16:
                    outputLabel.Text = "You stay here for a night. then another, and then another and you live there now. You find there is no reason to believe you need to return to your old home, for this is your new home.";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 17:
                    outputLabel.Text = "you died of loneliness!";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 18:
                    outputLabel.Text = "you died of dehydration!";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 19:
                    outputLabel.Text = "You died by getting run over by a car! what were you thinking?!";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 20:
                    outputLabel.Text = "You took the secret route and given up hope! play again?";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 21:
                    outputLabel.Text = "You won the game, congratulations! Play the game again ?";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                case 22:
                    outputLabel.Text = "You lost the game :( Play the game again ?";
                    RedLabel.Text = "";
                    BlueLabel.Text = "";
                    YellowLabel.Text = "";
                    sceneImage.BackgroundImage = Properties.Resources.Ending_Photo;
                    break;
                default:
                    break;
            }
        }

    }
}
