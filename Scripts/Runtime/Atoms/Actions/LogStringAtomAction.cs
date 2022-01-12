using niscolas.UnityUtils.Core;
using niscolas.UnityUtils.UnityAtoms;
using UnityAtoms;
using UnityEngine;

namespace niscolas.UnityUtils.UnityAtoms
{
    [CreateAssetMenu(
        menuName = UnityAtoms.Constants.ActionsCreateAssetMenuPrefix + "(string) => Log")]
    public class LogStringAtomAction : AtomAction<string>
    {
        [SerializeField]
        private LogType _logType = LogType.Log;

        public override void Do(string message)
        {
            TheBugger.Log(message, _logType);
        }
    }
}