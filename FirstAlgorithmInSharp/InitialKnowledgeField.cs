using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAlgorithmInSharp
{
    public static class InitialKnowledgeField
    {
        public static KnowledgeField Normal()
        {
            #region types and attrs
            Type firstType = new Type()
            {
                Id = 1,
                Name = "firstType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Type secondType = new Type()
            {
                Id = 2,
                Name = "secondType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Attribute firstAttr = new Attribute()
            {
                Id = 1,
                Name = "firstAttr",
                Type = firstType
            };

            Attribute secondAttr = new Attribute()
            {
                Id = 2,
                Name = "secondAttr",
                Type = secondType
            };

            #endregion

            #region objects
            TemporalObject firstTempObj = new TemporalObject()
            {
                Id = 1,
                Attrs = new List<Attribute>
                {
                    firstAttr,
                    secondAttr
                }
            };
            #endregion

            #region rules
            //impossible action
            TemporalRule firstTempRule = new TemporalRule()
            {
                Id = 1,
                Condition = new Condition
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        },
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "no"
                        }
                    }
                },

                Action = new Action
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "yes"
                        }
                    }
                }

            };
            #endregion


            KnowledgeField knowledgeField = new KnowledgeField();

            knowledgeField.Objects.Add(firstTempObj);
            knowledgeField.Rules.Add(firstTempRule);
            return knowledgeField;
        }

        public static KnowledgeField ImpossibleAction()
        {
            #region types and attrs
            Type firstType = new Type()
            {
                Id = 1,
                Name = "firstType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Type secondType = new Type()
            {
                Id = 2,
                Name = "secondType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Attribute firstAttr = new Attribute()
            {
                Id = 1,
                Name = "firstAttr",
                Type = firstType
            };

            Attribute secondAttr = new Attribute()
            {
                Id = 2,
                Name = "secondAttr",
                Type = secondType
            };

            #endregion

            #region objects
            TemporalObject firstTempObj = new TemporalObject()
            {
                Id = 1,
                Attrs = new List<Attribute>
                {
                    firstAttr,
                    secondAttr
                }
            };
            #endregion

            #region rules
            //impossible action
            TemporalRule firstTempRule = new TemporalRule()
            {
                Id = 1,
                Condition = new Condition
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        },
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "no"
                        }
                    }
                },

                Action = new Action
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "yes"
                        }
                    }
                }

            };
            #endregion


            KnowledgeField knowledgeField = new KnowledgeField();

            knowledgeField.Objects.Add(firstTempObj);
            knowledgeField.Rules.Add(firstTempRule);
            return knowledgeField;
        }

        public static KnowledgeField SuperfluousConditions()
        {
            #region types and attrs
            Type firstType = new Type()
            {
                Id = 1,
                Name = "firstType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Type secondType = new Type()
            {
                Id = 2,
                Name = "secondType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Attribute firstAttr = new Attribute()
            {
                Id = 1,
                Name = "firstAttr",
                Type = firstType
            };

            Attribute secondAttr = new Attribute()
            {
                Id = 2,
                Name = "secondAttr",
                Type = secondType
            };

            #endregion

            #region objects
            TemporalObject firstTempObj = new TemporalObject()
            {
                Id = 1,
                Attrs = new List<Attribute>
                {
                    firstAttr,
                    secondAttr
                }
            };
            #endregion

            #region rules
            //impossible action
            TemporalRule firstTempRule = new TemporalRule()
            {
                Id = 1,
                Condition = new Condition
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        },
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        }
                    }
                },

                Action = new Action
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "yes"
                        }
                    }
                }

            };
            #endregion


            KnowledgeField knowledgeField = new KnowledgeField();

            knowledgeField.Objects.Add(firstTempObj);
            knowledgeField.Rules.Add(firstTempRule);
            return knowledgeField;
        }

        public static KnowledgeField AttrWrongValue()
        {
            #region types and attrs
            Type firstType = new Type()
            {
                Id = 1,
                Name = "firstType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Type secondType = new Type()
            {
                Id = 2,
                Name = "secondType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Attribute firstAttr = new Attribute()
            {
                Id = 1,
                Name = "firstAttr",
                Type = firstType
            };

            Attribute secondAttr = new Attribute()
            {
                Id = 2,
                Name = "secondAttr",
                Type = secondType
            };

            #endregion

            #region objects
            TemporalObject firstTempObj = new TemporalObject()
            {
                Id = 1,
                Attrs = new List<Attribute>
                {
                    firstAttr,
                    secondAttr
                }
            };
            #endregion

            #region rules
            //impossible action
            TemporalRule firstTempRule = new TemporalRule()
            {
                Id = 1,
                Condition = new Condition
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "hack"
                        },
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "no"
                        }
                    }
                },

                Action = new Action
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = secondAttr,
                            Value = "yes"
                        }
                    }
                }

            };
            #endregion


            KnowledgeField knowledgeField = new KnowledgeField();

            knowledgeField.Objects.Add(firstTempObj);
            knowledgeField.Rules.Add(firstTempRule);
            return knowledgeField;
        }

        public static KnowledgeField AttrNotUsed()
        {
            #region types and attrs
            Type firstType = new Type()
            {
                Id = 1,
                Name = "firstType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Type secondType = new Type()
            {
                Id = 2,
                Name = "secondType",
                Values = new List<string>()
                {
                    "yes",
                    "no"
                }
            };

            Attribute firstAttr = new Attribute()
            {
                Id = 1,
                Name = "firstAttr",
                Type = firstType
            };

            Attribute secondAttr = new Attribute()
            {
                Id = 2,
                Name = "secondAttr",
                Type = secondType
            };

            #endregion

            #region objects
            TemporalObject firstTempObj = new TemporalObject()
            {
                Id = 1,
                Attrs = new List<Attribute>
                {
                    firstAttr,
                    secondAttr
                }
            };
            #endregion

            #region rules
            //impossible action
            TemporalRule firstTempRule = new TemporalRule()
            {
                Id = 1,
                Condition = new Condition
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        }
                    }
                },

                Action = new Action
                {
                    ListEq = new List<Eq>()
                    {
                        new Eq()
                        {
                            Attr = firstAttr,
                            Value = "yes"
                        }
                    }
                }

            };
            #endregion


            KnowledgeField knowledgeField = new KnowledgeField();

            knowledgeField.Objects.Add(firstTempObj);
            knowledgeField.Rules.Add(firstTempRule);
            return knowledgeField;
        }

    }
}
