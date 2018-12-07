﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemListEditor
{
	public static class Defines
	{
		public static void ItemEffects(ComboBox CB)
		{
			CB.Items.AddRange(new String[] {
				"EF_NONE",
				"EF_LEVEL",
				"EF_DAMAGE",
				"EF_AC",
				"EF_HP",
				"EF_MP",
				"EF_EXP",
				"EF_STR",
				"EF_INT",
				"EF_DEX",
				"EF_CON",
				"EF_SPECIAL1",
				"EF_SPECIAL2",
				"EF_SPECIAL3",
				"EF_SPECIAL4",
				"EF_SCORE14",
				"EF_SCORE15",
				"EF_POS",
				"EF_CLASS",
				"EF_R1SIDC",
				"EF_R2SIDC",
				"EF_WTYPE",
				"EF_REQ_STR",
				"EF_REQ_INT",
				"EF_REQ_DEX",
				"EF_REQ_CON",
				"EF_ATTSPEED",
				"EF_RANGE",
				"EF_PRICE",
				"EF_RUNSPEED",
				"EF_SPELL",
				"EF_DURATION",
				"EF_PARM2",
				"EF_GRID",
				"EF_GROUND",
				"EF_CLAN",
				"EF_HWORDCOIN",
				"EF_LWORDCOIN",
				"EF_VOLATILE",
				"EF_KEYID",
				"EF_PARRY",
				"EF_HITRATE",
				"EF_CRITICAL",
				"EF_SANC",
				"EF_SAVEMANA",
				"EF_HPADD",
				"EF_MPADD",
				"EF_REGENHP",
				"EF_REGENMP",
				"EF_RESIST1",
				"EF_RESIST2",
				"EF_RESIST3",
				"EF_RESIST4",
				"EF_ACADD",
				"EF_RESISTALL",
				"EF_BONUS",
				"EF_HWORDGUILD",
				"EF_LWORDGUILD",
				"EF_QUEST",
				"EF_UNIQUE",
				"EF_MAGIC",
				"EF_AMOUNT",
				"EF_HWORDINDEX",
				"EF_LWORDINDEX",
				"EF_INIT1",
				"EF_INIT2",
				"EF_INIT3",
				"EF_DAMAGEADD",
				"EF_MAGICADD",
				"EF_HPADD2",
				"EF_MPADD2",
				"EF_CRITICAL2",
				"EF_ACADD2",
				"EF_DAMAGE2",
				"EF_SPECIALALL",
				"EF_CURKILL",
				"EF_LTOTKILL",
				"EF_HTOTKILL",
				"EF_INCUBATE",
				"EF_MOUNTLIFE",
				"EF_MOUNTHP",
				"EF_MOUNTSANC",
				"EF_MOUNTFEED",
				"EF_MOUNTKILL",
				"EF_INCUDELAY",
				"EF_SUBGUILD",
				"EF_PREVBONUS",
				"EF_REFLEVEL",
				"EF_GAMEROOM",
				"EF_ABSDAM",
				"EF_ABSAC",
				"EF_UNK_91",
				"EF_UNK_92",
				"EF_UNK_93",
				"EF_UNK_94",
				"EF_UNK_95",
				"EF_UNK_96",
				"EF_UNK_97",
				"EF_UNK_98",
				"EF_UNK_99",
				"EF_GRADE0",
				"EF_GRADE1",
				"EF_GRADE2",
				"EF_GRADE3",
				"EF_GRADE4",
				"EF_GRADE5",
				"EF_DATE",
				"EF_HOUR",
				"EF_MIN",
				"EF_YEAR",
				"EF_MONTH",
				"EF_NOTRADE",
				"EF_TRANS",
				"EF_UNK_113",
				"EF_UNK_114",
				"EF_STARTCOL",
				"EF_COLOR0",
				"EF_COLOR1",
				"EF_COLOR2",
				"EF_COLOR3",
				"EF_COLOR4",
				"EF_COLOR5",
				"EF_COLOR6",
				"EF_COLOR7",
				"EF_COLOR8",
				"EF_COLOR9",
				"EF_COLOR0"
			});
		}
	}
}