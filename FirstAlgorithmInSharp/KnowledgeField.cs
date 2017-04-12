using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAlgorithmInSharp
{

    public class TemporalEntity
    {
        public int Id { get; set; }
    }

    public class Attribute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }
    }

    public class Type
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Values { get; set; }
    }

    public class TemporalObject : TemporalEntity
    {
        public List<Attribute> Attrs { get; set; }
    }

    public class Eq
    {
        public Attribute Attr { get; set; }
        public string Value { get; set; }
    }


    public class Condition
    {
        public List<Eq> ListEq { get; set; }
    }

    public class Action
    {
        public List<Eq> ListEq { get; set; }
    }


    public class TemporalRule : TemporalEntity
    {
        public Condition Condition { get; set; }
        public Action Action { get; set; }
    }

    public class TemporalInterval : TemporalEntity
    {

    }

    public class KnowledgeField
    {
        public KnowledgeField()
        {
            Objects = new List<TemporalObject>();
            Rules = new List<TemporalRule>();
            Intervals = new List<TemporalInterval>();
        }

        public List<TemporalObject> Objects { get; set; }
        public List<TemporalRule> Rules { get; set; }
        public List<TemporalInterval> Intervals;
    }
}
