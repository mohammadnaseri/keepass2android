/*
This file is part of Keepass2Android, Copyright 2013 Philipp Crocoll. This file is based on Keepassdroid, Copyright Brian Pellin.

  Keepass2Android is free software: you can redistribute it and/or modify
  it under the terms of the GNU General Public License as published by
  the Free Software Foundation, either version 2 of the License, or
  (at your option) any later version.

  Keepass2Android is distributed in the hope that it will be useful,
  but WITHOUT ANY WARRANTY; without even the implied warranty of
  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
  GNU General Public License for more details.

  You should have received a copy of the GNU General Public License
  along with Keepass2Android.  If not, see <http://www.gnu.org/licenses/>.
  */

using System;

namespace keepass2android
{
	
	public class Intents {
		public const String Timeout = "keepass2android.timeout";
		
		public const String CopyUsername = "keepass2android.copy_username";
		public const String CopyPassword = "keepass2android.copy_password";
		public const String CheckKeyboard = "keepass2android.check_keyboard";
		
		public const String FileBrowse = "org.openintents.action.PICK_FILE";
		public const int RequestCodeFileBrowseForOpen = 987321;
		public const int RequestCodeFileBrowseForCreate = 987322;
		public const int RequestCodeFileBrowseForBinary = 987323;
		public const int RequestCodeFileBrowseForKeyfile = 987324;

		public const String ShowNotification = "keepass2android.show_notification";
	}

}

