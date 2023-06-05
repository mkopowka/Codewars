using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codewars
{
    internal class CountSmileys
    {
        public static int CountSmiley(string[] smileys)
        {
            // Define the valid eye, nose, and mouth characters
            char[] validEyes = { ':', ';' };
            char[] validNoses = { '-', '~' };
            char[] validMouths = { ')', 'D' };

            // Count the valid smiley faces
            int count = 0;
            foreach (string face in smileys)
            {
                // Skip if the face length is less than 2 or more than 3
                if (face.Length < 2 || face.Length > 3)
                    continue;

                // Check the validity of eyes, nose, and mouth characters
                char eye = face[0];
                char nose = (face.Length == 3) ? face[1] : '\0';
                char mouth = face[face.Length - 1];

                if (validEyes.Contains(eye) && validMouths.Contains(mouth))
                {
                    // If there is a nose, check its validity
                    if (nose != '\0' && !validNoses.Contains(nose))
                        continue;

                    // Valid smiley face found
                    count++;
                }
            }

            return count;
        }
    }
}
