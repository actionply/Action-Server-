using System;

using MCGalaxy;

public class CmdGotoPixelArt : Command

{

	public override string name { get { return "gotopixelart"; } }

	public override string shortcut { get { return "pxl"; } }

	public override string type { get { return "other"; } }

	public override bool museumUsable { get { return true; } }

	public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }

	public override void Use(Player p, string message)
    { 
    Command.Find("goto").Use(p, "pixelart"); 


	} 
    
    public override void Help(Player p) {

		p.Message("&a/Pixelart&f - Teleports you to the pixel art map.");

	}

}
