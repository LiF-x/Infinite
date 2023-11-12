/**
* <author>Christophe Roblin</author>
* <url>lifxmod.com</url>
* <credits></credits>
* <description>Changes player.cs for server and client, requires basilmod for full effect</description>
* <license>GNU GENERAL PUBLIC LICENSE Version 3, 29 June 2007</license>
*/


if (!isObject(LiFxInfinite))
{
    new ScriptObject(LiFxInfinite)
    {
    };
}


package LiFxInfinite
{
  function LiFxInfinite::setup() {
    LiFx::registerCallback($LiFx::hooks::onInitServerDBChangesCallbacks, changePlayerData, LiFxInfinite);
    LiFx::registerCallback($LiFx::hooks::onPostInitCallbacks, Datablock, LiFxInfinite);
  }
  function LiFxInfinite::version() {
    return "0.0.1";
  }
   function LiFxInfinite::Datablock() {
        exec ("art/datablocks/player.cs", "mods/LiFx/Infinite/player.cs");
    }
  function LiFxInfinite::changePlayerData() {
    PlayerData.sprintCooldown = 0;
    exec("./player.cs");
  }
};
activatePackage(LiFxInfinite);
LiFx::registerCallback($LiFx::hooks::mods, setup, LiFxInfinite);