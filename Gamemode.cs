using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Media.Media3D;
using System.Net;

namespace CSharpGameMode {


    public class GameMode {


        static public bool OnPlayerConnected(SPlayer Player) {
            
            Player.SendMessage("zzz");
            return true;

        }


        static public bool OnGameModeExit() {

            return true;

        }


        static public bool OnPlayerDisconnect(SPlayer Player, DisconnectReason Reason) {
            
            return true;

        }


        static public bool OnPlayerSpawn(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerDeath(SPlayer Player, SPlayer Killer, string UsedWeapon) {

            return true;

        }


        static public bool OnVehicleSpawn(SVehicle Vehicle) {

            return true;

        }


        static public bool OnVehicleDeath(SVehicle Vehicle, SPlayer Killer) {

            return true;

        }


        static public bool OnPlayerText(SPlayer Player, string Text) {


            Player.SendMessage((Player.Score++).ToString() + "!");

            return true;

        }


        static public bool OnPlayerRequestClass(SPlayer Player, SPSkin WSkin) {

            return true;

        }


        static public bool OnPlayerEnterVehicle(SPlayer Player, SVehicle Vehicle, bool IsPassenger) {

            return true;

        }


        static public bool OnPlayerExitVehicle(SPlayer Player, SVehicle Vehicle) {

            return true;

        }


        static public bool OnPlayerEnterCheckpoint(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerLeaveCheckpoint(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerEnterRaceCheckpoint(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerLeaveRaceCheckpoint(SPlayer Player) {

            return true;

        }


        static public bool OnRconCommand(string Command) {

            return true;

        }


        static public bool OnPlayerRequestSpawn(SPlayer Player) {

            return true;

        }


        static public bool OnObjectMoved(SObj Object) {

            return true;

        }


        static public bool OnPlayerObjectMoved(SPlayer Player, SPlayerObj Object) {

            return true;

        }


        static public bool OnPlayerPickUpPickup(SPlayer Player, SPickup Pick) {

            return true;

        }


        static public bool OnVehicleMod(SPlayer Player, SVehicle Vehicle, VehComponent Component) {

            return true;

        }


        static public bool OnEnterExitModShop(SPlayer Player, bool Entered, int InteriorId) {

            return true;

        }


        static public bool OnVehiclePaintjob(SPlayer Player, SVehicle Vehicle, int PaintJobId) {

            return true;

        }


        static public bool OnVehicleRespray(SPlayer Player, SVehicle Vehicle, SGColor Color1, SGColor Color2) {
            
            return true;

        }


        static public bool OnVehicleDamageStatusUpdate(SPlayer Player, SVehicle Vehicle) {

            return true;

        }


        static public bool OnUnoccupiedVehicleUpdate(SPlayer Player, SVehicle Vehicle, VehicleSeats PassengerSeat) {

            return true;

        }


        static public bool OnPlayerSelectedMenuRow(SPlayer Player, int Row) {

            return true;

        }


        static public bool OnPlayerExitedMenu(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerInteriorChange(SPlayer Player, int newIntId, int oldintId) {

            return true;

        }


        static public bool OnRconLoginAttempt(IPAddress IP, string Password, bool Success) {

            return true;

        }


        static public bool OnPlayerUpdate(SPlayer Player) {

            return true;

        }


        static public bool OnPlayerStreamIn(SPlayer Player, SPlayer For) {

            return true;

        }


        static public bool OnPlayerStreamOut(SPlayer Player, SPlayer For) {

            return true;

        }


        static public bool OnVehicleStreamIn(SVehicle Vehicle, SPlayer Player) {

            return true;

        }


        static public bool OnVehicleStreamOut(SVehicle Vehicle, SPlayer Player) {

            return true;

        }


        static public bool OnPlayerTakeDamage(SPlayer Player, SPlayer From, float Amount, string UsedWep) {

            return true;

        }


        static public bool OnPlayerGiveDamage(SPlayer Player, SPlayer To, float Amount, string UsedWep) {

            return true;

        }


        static public bool OnDialogResponse(SPlayer Player, int DialogId, bool LeftButtunClicked, int ListItem, string Inputtext) {

            return true;

        }


        static public bool OnPlayerClickMap(SPlayer Player, Point3D Pos) {

            return true;

        }


        static public bool OnPlayerClickPlayer(SPlayer Player, SPlayer Clicked, bool UsedScoreBoard) {

            return true;

        }


        static public bool OnPlayerCommandText(SPlayer Player, string Command) {

            return true;

        }


        static public bool OnPlayerEditObject(SPlayer Player, SObj Object, SPlayerObj PObj, bool IsCancelled, bool IsSaved, bool IsUpdate, Point3D Pos, Point3D Rotation) {

            return true;

        }


        static public bool OnPlayerEditAttachedObject(SPlayer Player, bool IsSaved, bool IsCancelled, SObjectsEnum Model, string Bone, Point3D Pos, Point3D Rotation, Point3D Scale) {

            return true;

        }


        static public bool OnPlayerSelectObject(SPlayer Player, SObj Object, SPlayerObj PObj, SObjectsEnum Model, Point3D Pos) {

            return true;

        }


        static public bool OnPlayerClickTextDraw(SPlayer Player, STextDraw TextDraw) {

            return true;

        }


        static public bool OnPlayerClickPlayerTextDraw(SPlayer Player, SPTextDraw TextDraw) {

            return true;

        }


        static public bool OnGameModeInit() {

            return true;

        }


        static public bool OnPlayerStateChange(SPlayer Player, PlayerStates NewState, PlayerStates OldState) {

            return true;

        }


        static public bool OnPlayerKeyStateChange(SPlayer Player, Keys NewKeys, Keys OldKeys) {

            return true;

        }




    }

}
