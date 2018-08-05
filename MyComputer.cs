//----------------------------------------------------------------------------------------
//	Copyright © 2003 - 2018 Tangible Software Solutions Inc.
//	This class can be used by anyone provided that the copyright notice remains intact.
//
//	This class allows the following VB My.Computer properties to be called from C#:
//	My.Computer.Audio
//	My.Computer.Clock
//	My.Computer.Info
//	My.Computer.Keyboard
//	My.Computer.Mouse
//	My.Computer.Network
//	My.Computer.Ports
//
//	Notes:
//	1. A reference to the Microsoft.VisualBasic assembly is required.
//	2. Calls to My.Computer.Clipboard, My.Computer.FileSystem, My.Computer.Name,
//	My.Computer.Registry, and My.Computer.Screen are converted inline.
//----------------------------------------------------------------------------------------

using Microsoft.VisualBasic.Devices;

namespace DuplicateFileFinder.My
{
	public static class Computer
	{
		public readonly static Audio Audio = new Audio();
		public readonly static Clock Clock = new Clock();
		public readonly static ComputerInfo Info = new ComputerInfo();
		public readonly static Keyboard Keyboard = new Keyboard();
		public readonly static Mouse Mouse = new Mouse();
		public readonly static Network Network = new Network();
		public readonly static Ports Ports = new Ports();
	}
}