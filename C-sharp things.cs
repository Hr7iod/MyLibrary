private static string GetRandomSubstring(string text, int length)
        {
	    if (length < 1) return "";	
            string s = "";
            using (RNGCryptoServiceProvider provider = new RNGCryptoServiceProvider())
            {
                while (s.Length != length)
                {
                    byte[] oneByte = new byte[1];
                    provider.GetBytes(oneByte);
                    char character = (char)oneByte[0];
                    if (text.Contains(character))
                    {
                        s += character;
                    }
                }
            }
            return s;
        }


public static string TransliterateString(string string1)
        {
            Dictionary<char, string> dic = new Dictionary<char, string>
            {
                { 'а', "a" },
                { 'б', "b" },
                { 'в', "v" },
                { 'г', "g" },
                { 'д', "d" },
                { 'е', "e" },
                { 'ё', "e" },
                { 'ж', "zh" },
                { 'з', "z" },
                { 'и', "i" },
                { 'й', "i" },
                { 'к', "k" },
                { 'л', "l" },
                { 'м', "m" },
                { 'н', "n" },
                { 'о', "o" },
                { 'п', "p" },
                { 'р', "r" },
                { 'с', "s" },
                { 'т', "t" },
                { 'у', "u" },
                { 'ф', "f" },
                { 'х', "h" },
                { 'ц', "c" },
                { 'ч', "ch" },
                { 'ш', "sh" },
                { 'щ', "shch" },
                { 'ъ', "" },
                { 'ы', "y" },
                { 'ь', "" },
                { 'э', "e" },
                { 'ю', "yu" },
                { 'я', "ya" }
            };

            string string2 = "";

            for (int i = 0; i < string1.Length; i++)
            {
                if (dic.ContainsKey(string1[i]))
                {
                    string2 += dic[string1[i]];
                }
                else
                {
                    if (char.IsUpper(string1[i]))
                    {
                        if (dic.ContainsKey(char.ToLower(string1[i])))
                        {
                            string2 += dic[char.ToLower(string1[i])].ToUpper();
                        }
                        else
                        {
                            string2 += string1[i];
                        }
                    }
                    else
                    {
                        string2 += string1[i];
                    }
                }
            }

            return string2;
        }
        


public static string FirstLetterUpper(string string1)
        {
            return string1.Substring(0, 1).ToUpper() + string1.Substring(1).ToLower();
        }



public static void BlinkControl(System.Windows.Controls.Control control, System.Windows.Media.Color color, int time = 100)
        {
            var brush = control.Background.Clone();
            control.Background = brush;
            var ca = new System.Windows.Media.Animation.ColorAnimation(color, TimeSpan.FromMilliseconds(time)) { AutoReverse = true };
            brush.BeginAnimation(System.Windows.Media.SolidColorBrush.ColorProperty, ca);
        }

