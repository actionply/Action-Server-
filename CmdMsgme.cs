using System;
namespace MCGalaxy {

	public class CmdMsgme : Command {

		public override string name { get { return "MsgMe"; } }

		public override string shortcut { get { return ""; } }

		public override string type { get { return "other"; } }

		public override bool museumUsable { get { return true; } }

		public override LevelPermission defaultRank { get { return LevelPermission.Banned; } }

		public override void Use(Player p, string message) {

			p.Message("%7" + message);

		}

		

		public override void Help(Player p) {

			p.Message("/MsgMe <Message>");

			p.Message("Sends a message to yourself.");

		}

	}

}
