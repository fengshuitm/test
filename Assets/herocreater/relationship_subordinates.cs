﻿using UnityEngine;
using System.Collections;

public class relationship_subordinates: listselect_script
{
	public relationship_subordinates ()
	{

	}

	public override void invalidatelist()
	{
		herodata temphero = Global_HeroData.getInstance ().List_hero [GlobalData.getInstance ().nowheroid];

		listcount =temphero.m_relationship.subordinatecount;

		//int [] tempheroiddata;
		clearlist ();

		for (int i = 0; i < preftemp_list.Length; i++) {

			int i_id_flag = i + listbegin;
			//int i_id = 0;

			if (i_id_flag >= listcount) {
				return;
			}

			//tempheroiddata=Global_HeroData.getInstance().List_hero;

			//i_id = tempheroiddata [i_id_flag];

			RelationShip_selectItem hero_item = preftemp_list[i].GetComponent<RelationShip_selectItem>();
			hero_item.set_ID (temphero.m_relationship.subordinateid[i_id_flag]);
		}


	}




}