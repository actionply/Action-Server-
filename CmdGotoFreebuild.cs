using System;
using MCGalaxy;

public class CmdGotoFreebuild : Command
{
	public override string name { get { return "gotofreebuild"; } }
	public override string shortcut { get { return "fbgo"; } }
	public override string type { get { return "other"; } }
	public override bool museumUsable { get { return true; } }
	public override LevelPermission defaultRank { get { return LevelPermission.Guest; } }
	public override void Use(Player p, string message)
	{
    Command.Find("goto").Use(p, "freebuild");
    }
    public override void Help(Player p) {
		p.Message("&a/Freebuild&f - Teleports you to freebuild.");
	}
}
