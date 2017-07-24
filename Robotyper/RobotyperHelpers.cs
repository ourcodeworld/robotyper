using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.ComponentModel;
using WindowsInput.Native;
using WindowsInput;
using System.Media;
using System.Threading;

namespace Robotyper
{
    class RobotyperHelpers
    {
        private bool ThreadStopped;

        private string Text;

        public event EventHandler<ThreadResponse> OnProgressChanged;
        public event EventHandler<ThreadResponse> OnTypingEnd;

        private readonly SynchronizationContext SyncContext;

        public RobotyperHelpers()
        {
            SyncContext = AsyncOperationManager.SynchronizationContext;
        }

        public void Stop()
        {
            ThreadStopped = true;
            this.Text = null;
        }

        public void StartTypingCharacters(string Text)
        {
            this.Text = Text;
            Thread thread = new Thread(simulateTypingByCharacters);
            thread.IsBackground = true;
            thread.Start();
        }

        public void StartTypingWords(string Text)
        {
            this.Text = Text;
            Thread thread = new Thread(simulateTypingByWords);
            thread.IsBackground = true;
            thread.Start();
        }

        private void simulateTypingByCharacters()
        {
            while (!ThreadStopped)
            {
                InputSimulator sim = new InputSimulator();

                sim.Keyboard.Sleep(Properties.Settings.Default.typingStartDelay);

                if (Properties.Settings.Default.enableBeep)
                {
                    SystemSounds.Beep.Play();
                }

                string[] lines = Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);
                int maximum = lines.Length;
                int current = 1;

                foreach (string line in lines)
                {
                    char[] words = line.ToCharArray();

                    foreach (char word in words)
                    {
                        sim.Keyboard.TextEntry(word).Sleep(Properties.Settings.Default.typingDelay);
                    }

                    float percentage = ((float)current / (float)maximum) * 100;
                     
                    SyncContext.Post(e => triggerOnProgressChanged(
                        new ThreadResponse((int)Math.Ceiling(percentage))
                    ), null);

                    current++;

                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                }

                if (Properties.Settings.Default.enableBeep)
                {
                    SystemSounds.Beep.Play();
                }

                SyncContext.Post(e => triggerOnTypingEnd(
                    new ThreadResponse((current / maximum) * 100)
                ), null);

                Stop();
            }
        }

        public void simulateTypingByWords()
        {
            while (!ThreadStopped)
            {
                InputSimulator sim = new InputSimulator();

                sim.Keyboard.Sleep(Properties.Settings.Default.typingStartDelay);

                if (Properties.Settings.Default.enableBeep)
                {
                    SystemSounds.Beep.Play();
                }

                string[] lines = Text.Split(new string[] { "\r\n", "\n" }, StringSplitOptions.None);

                int maximum = lines.Length;
                int current = 1;

                foreach (string line in lines)
                {
                    string[] words = Regex.Split(line, @"(?<=[\S\n])(?=\s)");

                    foreach (string word in words)
                    {
                        if (!String.IsNullOrEmpty(word))
                        {
                            sim.Keyboard.TextEntry(word).Sleep(Properties.Settings.Default.typingDelay);
                        }
                    }

                    float percentage = ((float)current / (float)maximum) * 100;

                    SyncContext.Post(e => triggerOnProgressChanged(
                        new ThreadResponse((int)Math.Ceiling(percentage))
                    ), null);

                    current++;

                    sim.Keyboard.KeyPress(VirtualKeyCode.RETURN);
                    sim.Keyboard.KeyPress(VirtualKeyCode.HOME);
                }

                if (Properties.Settings.Default.enableBeep)
                {
                    SystemSounds.Beep.Play();
                }

                SyncContext.Post(e => triggerOnTypingEnd(
                    new ThreadResponse((current / maximum) * 100)
                ), null);

                Stop();
            }
        }

        private void triggerOnProgressChanged(ThreadResponse response)
        {
            OnProgressChanged?.Invoke(this, response);
        }

        private void triggerOnTypingEnd(ThreadResponse response)
        {
            OnTypingEnd?.Invoke(this, response);
        }
    }

    public class ThreadResponse
    {
        private readonly int progress;

        public ThreadResponse(int progress)
        {
            this.progress = progress;
        }

        public int Progress {
            get { return progress; }
        }
    }
}
