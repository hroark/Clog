using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using clog.Interfaces;

namespace Clog
{
    internal class LoggerEnumerator
    {
        private IEnumerable<ILoggable> LoadRules()
        {
            var loggers = new List<ILoggable>();

            Assembly thisAssembly = Assembly.GetAssembly(typeof(ProficiencyChecker));

            Type[] typesImplementRule = thisAssembly
                .GetTypes()
                .Where(t => typeof(IProficiencyRule).IsAssignableFrom(t) && t.IsClass)
                .ToArray();

            foreach (Type rule in typesImplementRule)
            {
                IProficiencyRule proficiencyRule = Activator.CreateInstance(rule) as IProficiencyRule;
                rules.Add(proficiencyRule);
            }

            return rules;
        }
    }
}