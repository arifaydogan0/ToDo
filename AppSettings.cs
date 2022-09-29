namespace ToDo
{
    class AppSettings
    {
        static string settingsLocationPath = Application.StartupPath + @"\AppData\Settings\location.txt";
        static string settingsSizePath = Application.StartupPath + @"\AppData\Settings\size.txt";
        static string settingsContentPath = Application.StartupPath + @"\AppData\Settings\content.txt";

        public static Point Location
        {
            get
            {
                Point p = new Point();

                if (!File.Exists(settingsLocationPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsLocationPath));
                    File.Create(settingsLocationPath).Close();
                    using (StreamWriter sw = new(settingsLocationPath))
                    {
                        sw.WriteLine($"0\n0");
                    }
                }
                using (StreamReader sr = new(settingsLocationPath))
                {
                    string[] _ = sr.ReadToEnd().Split('\n');
                    p.X = int.Parse(_[0] ?? "0");
                    p.Y = int.Parse(_[1] ?? "0");
                    return p;
                }
            }

            set
            {
                if (!File.Exists(settingsLocationPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsLocationPath));
                    File.Create(settingsLocationPath).Close();
                }
                else
                {
                    File.Delete(settingsLocationPath);
                    File.Create(settingsLocationPath).Close();
                }

                using (StreamWriter sw = new(settingsLocationPath))
                {
                    sw.WriteLine($"{value.X}\n{value.Y}");
                }
            }
        }
        public static Size Size
        {
            get
            {
                Size s = new Size();

                if (!File.Exists(settingsSizePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsSizePath));
                    File.Create(settingsSizePath).Close();
                    using (StreamWriter sw = new(settingsSizePath))
                    {
                        sw.WriteLine($"300\n300");
                    }
                }
                using (StreamReader sr = new(settingsSizePath))
                {
                    string[] _ = sr.ReadToEnd().Split('\n');
                    s.Width = int.Parse(_[0] ?? "0");
                    s.Height = int.Parse(_[1] ?? "0");
                    return s;
                }
            }

            set
            {
                if (!File.Exists(settingsSizePath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsSizePath));
                    File.Create(settingsSizePath).Close();
                }
                else
                {
                    File.Delete(settingsSizePath);
                    File.Create(settingsSizePath).Close();
                }

                using (StreamWriter sw = new(settingsSizePath))
                {
                    sw.WriteLine($"{value.Width}\n{value.Height}");
                }
            }

        }
        public static string Content
        {
            get
            {
                string s = "";

                if (!File.Exists(settingsContentPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsContentPath));
                    File.Create(settingsContentPath).Close();
                    using (StreamWriter sw = new(settingsContentPath))
                    {
                        sw.WriteLine($"");
                    }
                }
                using (StreamReader sr = new(settingsContentPath))
                {
                    s = sr.ReadToEnd();
                    return s;
                }
            }

            set
            {
                if (!File.Exists(settingsContentPath))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(settingsContentPath));
                    File.Create(settingsContentPath).Close();
                }
                else
                {
                    File.Delete(settingsContentPath);
                    File.Create(settingsContentPath).Close();
                }

                using (StreamWriter sw = new(settingsContentPath))
                {
                    sw.WriteLine(value);
                }
            }

        }
    }
}