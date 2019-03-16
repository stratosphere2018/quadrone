using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Stratosphere.Quadrone
{
    public enum SceneName
    {
        None,
        [StringValueAttribute("Scenes")]
        Root,
        [StringValueAttribute("Loading")]
        Loading,
        [StringValueAttribute("Title")]
        Title,
        [StringValueAttribute("Home")]
        Home,
        [StringValueAttribute("Battle")]
        Battle,
        // 不足
        // 随時足してください
    }
}

