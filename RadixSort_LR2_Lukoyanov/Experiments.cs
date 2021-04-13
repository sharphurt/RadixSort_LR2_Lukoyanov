using System.Xml.Serialization;

namespace RadixSort_LR2_Lukoyanov
{
    [XmlRoot("experiments")]
    public class Experiments
    {
        [XmlElement("experiment")] public Experiment[] ExperimentsArray;
    }

    public class Experiment
    {
        [XmlAttribute("name")] public string Name;

        [XmlElement("nodes")] public Node[] Nodes;
    }

    public class Node
    {
        [XmlAttribute("name")] public string Name;

        [XmlAttribute("minElement")] public int MinElement;

        [XmlAttribute("maxElement")] public int MaxElement;

        [XmlAttribute("startLength")] public int StartLength;

        [XmlAttribute("diff")] public float Diff;

        [XmlAttribute("Znamen")] public float Denominator;

        [XmlAttribute("maxLength")] public int MaxLength;

        [XmlAttribute("repeat")] public int Repeats;
    }
}