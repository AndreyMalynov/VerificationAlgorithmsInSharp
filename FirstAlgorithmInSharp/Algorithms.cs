using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAlgorithmInSharp
{
    public static class Algorithms
    {
        #region Impossible action
        public static void ImpossibleAction(KnowledgeField knowledgeField)
        {
            for (int i = 0; i < knowledgeField.Rules.Count; i++)
            {
                if (HasRuleImpossibleAction(knowledgeField.Rules[i]))
                {
                    Console.WriteLine("rule " + knowledgeField.Rules[i].Id + " has impossible action");
                }
            }
        }

        private static bool HasRuleImpossibleAction(TemporalRule rule)
        {
            Action currentAction = rule.Action;
            Condition currentCondition = rule.Condition;

            for (int j = 0; j < currentCondition.ListEq.Count; j++)
            {
                for (int k = j + 1; k < currentCondition.ListEq.Count; k++)
                {
                    //there is also necessary to check operator ('or' or 'and')
                    if ((currentCondition.ListEq[j].Attr.Id == currentCondition.ListEq[k].Attr.Id)
                        && (currentCondition.ListEq[j].Value != currentCondition.ListEq[k].Value))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        #endregion

        #region AttrWrongValue
        public static void AttrWrongValue(KnowledgeField knowledgeField)
        {
            for (int i = 0; i < knowledgeField.Rules.Count; i++)
            {
                if (HasRuleAttrWrongValue(knowledgeField.Rules[i]))
                {
                    Console.WriteLine("rule " + knowledgeField.Rules[i].Id + " has attr wrong value");
                }
            }
        }

        private static bool HasRuleAttrWrongValue(TemporalRule rule)
        {
            Action currentAction = rule.Action;
            Condition currentCondition = rule.Condition;

            for (int j = 0; j < currentCondition.ListEq.Count; j++)
            {
                if (!BelongToTypeSetValue(currentCondition.ListEq[j]))
                    return true;
            }
            for (int j = 0; j < currentAction.ListEq.Count; j++)
            {
                if (!BelongToTypeSetValue(currentAction.ListEq[j]))
                    return true;
            }
            return false;
        }

        private static bool BelongToTypeSetValue(Eq eq)
        {
            //after to add other types like set of numbers
            return
                (eq.Attr.Type.Values.Any(x => string.Equals(x, eq.Value, StringComparison.CurrentCultureIgnoreCase)))
                ? true : false;
        }
        #endregion


        #region Superfluous conditions
        public static void SuperfluousConditions(KnowledgeField knowledgeField)
        {
            for (int i = 0; i < knowledgeField.Rules.Count; i++)
            {
                if (HasRuleSuperflousCondition(knowledgeField.Rules[i]))
                {
                    Console.WriteLine("rule " + knowledgeField.Rules[i].Id + " has superflous condition");
                }
            }
        }

        private static bool HasRuleSuperflousCondition(TemporalRule rule)
        {
            Condition currentCondition = rule.Condition;

            for (int i = 0; i < currentCondition.ListEq.Count; i++)
            {
                for (int j = i + 1; j < currentCondition.ListEq.Count; j++)
                {
                    if ((currentCondition.ListEq[i].Attr.Id == currentCondition.ListEq[j].Attr.Id)
                        && (currentCondition.ListEq[i].Value == currentCondition.ListEq[j].Value))
                        return true;
                }
            }
            return false;
        }

        #endregion


        #region AttrNotUsed
        public static void AttrNotUsed(KnowledgeField knowledgeField)
        {
            for (int i = 0; i < knowledgeField.Objects.Count; i++)
            {
                for (int j = 0; j < knowledgeField.Objects[i].Attrs.Count; j++)
                {
                    if (IsAttrUsedInRule(knowledgeField, knowledgeField.Objects[i].Attrs[j]))
                    {
                        Console.WriteLine("attr " + knowledgeField.Objects[i].Attrs[j].Id + " not used");
                    }
                }
            }
        }

        private static bool IsAttrUsedInRule(KnowledgeField knowledgeField, Attribute attr)
        {
            for (int i = 0; i < knowledgeField.Rules.Count; i++)
            {
                for (int j = 0; j < knowledgeField.Rules[i].Condition.ListEq.Count; j++)
                {
                    if (knowledgeField.Rules[i].Condition.ListEq[j].Attr.Id == attr.Id)
                        return false;
                }
                for (int j = 0; j < knowledgeField.Rules[i].Action.ListEq.Count; j++)
                {
                    if (knowledgeField.Rules[i].Action.ListEq[j].Attr.Id == attr.Id)
                        return false;
                }
            }
            return true;
        }
        #endregion
    }
}

