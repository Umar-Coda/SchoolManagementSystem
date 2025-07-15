using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMSBusinessLogicLayer.Utilities {
    public static class FuzzySearchHelper {
        public static double JaroWinklerDistance(string s1, string s2) {
            if (s1 == null || s2 == null)
                return 0.0;

            s1 = s1.ToLower();
            s2 = s2.ToLower();

            int len1 = s1.Length;
            int len2 = s2.Length;

            if (len1 == 0) return len2 == 0 ? 1.0 : 0.0;

            int matchDistance = Math.Max(len1, len2) / 2 - 1;
            bool[] s1Matches = new bool[len1];
            bool[] s2Matches = new bool[len2];

            int matches = 0;
            for (int i = 0; i < len1; i++) {
                int start = Math.Max(0, i - matchDistance);
                int end = Math.Min(i + matchDistance + 1, len2);

                for (int j = start; j < end; j++) {
                    if (s2Matches[j]) continue;
                    if (s1[i] != s2[j]) continue;

                    s1Matches[i] = true;
                    s2Matches[j] = true;
                    matches++;
                    break;
                }
            }

            if (matches == 0) return 0.0;

            double t = 0;
            int k = 0;
            for (int i = 0; i < len1; i++) {
                if (!s1Matches[i]) continue;
                while (!s2Matches[k]) k++;
                if (s1[i] != s2[k]) t++;
                k++;
            }

            t /= 2.0;

            double jaro = ((matches / (double)len1) + (matches / (double)len2) + ((matches - t) / matches)) / 3.0;

            // Jaro-Winkler boost
            int prefix = 0;
            for (int i = 0; i < Math.Min(4, Math.Min(s1.Length, s2.Length)); i++) {
                if (s1[i] == s2[i])
                    prefix++;
                else
                    break;
            }

            return jaro + prefix * 0.1 * (1 - jaro);
        }
    }
}
