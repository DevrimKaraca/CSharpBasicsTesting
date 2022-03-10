using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleRowParseAndSave
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOFFilePath0Kb = @"C:\Users\dkaraca\Desktop\0KbList\zzz.txt";
            string eds0KbListFilePath = @"C:\Users\dkaraca\Desktop\0KbList\2022OcakEds0KbList.txt";
            string pts0KbListFilePath = @"C:\Users\dkaraca\Desktop\0KbList\2022OcakPts0KbList.txt";

            if (File.Exists(eds0KbListFilePath)) File.Delete(eds0KbListFilePath);
            if (File.Exists(pts0KbListFilePath)) File.Delete(pts0KbListFilePath);
            
            List<string> fileContentLines = File.ReadAllLines(nameOFFilePath0Kb,Encoding.UTF8).ToList<string>();

            List<string> fileContentEDSPlates = new List<string>();
            List<string> fileContentPTSPlates = new List<string>();

            List<KeyValuePair<int, string>> fileContentEDSPlatesIntString = new List<KeyValuePair<int, string>>();
            List<KeyValuePair<int, string>> fileContentPTSPlatesIntString = new List<KeyValuePair<int, string>>();

            List<string> fileContentEDSNodeID = new List<string>();
            List<string> fileContentPTSNodeID = new List<string>();
            
            List<string> fileContentEDSPath = new List<string>();
            List<string> fileContentPTSPath = new List<string>();

            List<string> fileContentEDSTimeStamp = new List<string>();
            List<string> fileContentPTSTimeStamp = new List<string>();

            int counter = 0;
            int countEds = 0;
            int countPts = 0;

            string parser1 = "- EDS\\";
            string parser2 = "- PTS\\";
            string parser = "";

            

            foreach (var item in fileContentLines)
            {
                if (item.Contains(parser1))
                {
                    parser = parser1;
                    string platecontroled = item.Split(new string[] { "- EDS\\" }, StringSplitOptions.None)[1].Split('\\')[1].Split('-')[0];
                    if (platecontroled.Length != 11)
                    {
                        int countPlate = platecontroled.Length;
                        for (int i = 0; i < 11 - countPlate; i++)
                        {
                            platecontroled = string.Concat(platecontroled, " ");
                        }
                    }
                    string plate = "Plaka : " + String.Format("'{0}'", platecontroled);

                    string nodeId = item.Split('\\')[7].Split('-')[0].Trim();
                    string nodeIdString = "NodeId : " + String.Format("'{0}' ", nodeId);
                    
                    string path = "Path : " + String.Format("'{0}'", item);

                    string timeStamp = item.Split(new string[] { "- EDS\\" }, StringSplitOptions.None)[1].Split('\\')[1];
                    string timeStampDateFirstPart = timeStamp.Split('_')[2].Replace('-', ';');
                    string timeStampDateSecondPart = timeStamp.Split('_')[3].Replace('-', ';');
                    string tmstmp = "TimeStamp : " + String.Format("'{0}'", timeStampDateFirstPart + timeStampDateSecondPart + " ");

                    fileContentEDSPlatesIntString.Add(new KeyValuePair<int, string>(Convert.ToInt32(nodeId), tmstmp + nodeIdString + plate + path ));

                    fileContentEDSTimeStamp.Add("TimeStamp : " + timeStampDateFirstPart + timeStampDateSecondPart);
                    countEds++;
                }
                if (item.Contains(parser2))
                {
                    parser = parser2;
                    string platecontroled = item.Split(new string[] { "- PTS\\" }, StringSplitOptions.None)[1].Split('\\')[1].Split('-')[0];
                    if (platecontroled.Length != 11)
                    {
                        int countPlate = platecontroled.Length;
                        for (int i = 0; i < 11 - countPlate; i++)
                        {
                            platecontroled = string.Concat(platecontroled, " ");
                        }
                    }
                    string plate = "Plaka : " + String.Format("'{0}'", platecontroled);

                    string nodeId = item.Split('\\')[7].Split('-')[0].Trim();
                    string nodeIdString = "NodeId : " + String.Format("'{0}' ", nodeId);

                    string path = "Path : " + String.Format("'{0}'", item);

                    string timeStamp = item.Split(new string[] { "- PTS\\" }, StringSplitOptions.None)[1].Split('\\')[1];
                    string timeStampDateFirstPart = timeStamp.Split('_')[2].Replace('-', ';');
                    string timeStampDateSecondPart = timeStamp.Split('_')[3].Replace('-', ';');
                    string tmstmp = "TimeStamp : " + String.Format("'{0}'",timeStampDateFirstPart + timeStampDateSecondPart + " ");

                    fileContentPTSPlatesIntString.Add(new KeyValuePair<int, string>(Convert.ToInt32(nodeId), tmstmp + nodeIdString + plate + path));

                    fileContentPTSTimeStamp.Add(timeStampDateFirstPart + timeStampDateSecondPart);
                    countPts++;
                }
                counter++;
            }
            fileContentEDSPlatesIntString = fileContentEDSPlatesIntString.OrderBy(x => x.Key).ToList();
            fileContentPTSPlatesIntString = fileContentPTSPlatesIntString.OrderBy(x => x.Key).ToList();

            List<int> errorNodeIdListEds = new List<int>();
            List<int> errorNodeIdListPts = new List<int>();

            for (int i = 0; i < countEds; i++)
            {
                errorNodeIdListEds.Add(fileContentEDSPlatesIntString[i].Key);
            }
            for (int i = 0; i < countPts; i++)
            {
                errorNodeIdListPts.Add(fileContentPTSPlatesIntString[i].Key);
            }

            errorNodeIdListEds = errorNodeIdListEds.Distinct().ToList();
            errorNodeIdListPts = errorNodeIdListPts.Distinct().ToList();


            for (int i = 0; i < countEds; i++)
            {
                File.AppendAllText(eds0KbListFilePath, fileContentEDSPlatesIntString[i].Value + "\n");
            }

            for (int i = 0; i < countPts; i++)
            {
                File.AppendAllText(pts0KbListFilePath, fileContentPTSPlatesIntString[i].Value + "\n");
            }

            for (int i = 0; i < errorNodeIdListEds.Count; i++)
            {
                File.AppendAllText(eds0KbListFilePath+"nodublicateEDS.txt", errorNodeIdListEds[i].ToString() + "\n");
            }

            for (int i = 0; i < errorNodeIdListPts.Count; i++)
            {
                File.AppendAllText(pts0KbListFilePath+"nodublicatePTS.txt", errorNodeIdListPts[i].ToString() + "\n");
            }

        }
    }
}
