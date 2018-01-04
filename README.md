# lapazz-graphic-tablet-WTC-client



UC Logic Lapazz Athena M MN853 Graphic Tablet on Windows 10 there is a problem occurring while drawing on Adobe Photoshop. I made some conversation with UC Logic technical support at the and they told me to return device. I try lots of things to solve this but i couldn't. Meanwhile i was displaying working tasks on Windows 10 and i realize WTClient.exe stop working first 5 minutes when i plugged the graphic tablet device. This was obvious so i decided to make a program on Visual C# that controls to WTClient.exe it aims to start WTClient.exe if it's stop working. Wow i solved my problem and saved 280$ graphic tablet device. I know there were a lot of people facing this problem. 




        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                foreach (var process in Process.GetProcessesByName("WTClient"))
                {
                    process.Kill();
                }

                System.Diagnostics.Process.Start(@"C:\Windows\SysWOW64\WTClient.exe");
            }
            catch(Exception)
            {

            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
        }
