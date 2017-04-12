using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAlgorithmInSharp
{
    class Program
    {
        static void Main()
        {
            KnowledgeField knowledgeField = InitialKnowledgeField.Normal();
            //KnowledgeField knowledgeField = InitialKnowledgeField.AttrNotUsed();
            //KnowledgeField knowledgeField = InitialKnowledgeField.AttrWrongValue();
            //KnowledgeField knowledgeField = InitialKnowledgeField.ImpossibleAction();
            //KnowledgeField knowledgeField = InitialKnowledgeField.SuperfluousConditions();

            Algorithms.ImpossibleAction(knowledgeField);
            Algorithms.AttrWrongValue(knowledgeField);
            Algorithms.SuperfluousConditions(knowledgeField);
            Algorithms.AttrNotUsed(knowledgeField);

            Console.WriteLine();
        }


        
    }

}
