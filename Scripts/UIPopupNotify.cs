﻿// =======================================================================================
// UIPopupNotify
// by Weaver (Fhiz)
// MIT licensed
// =======================================================================================

using wovencode;
using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

namespace wovencode
{

	// ===================================================================================
	// UIPopupNotify
	// ===================================================================================
	[DisallowMultipleComponent]
	public partial class UIPopupNotify: UIPopup
	{

		public static UIPopupNotify singleton;
		
		// -------------------------------------------------------------------------------
		// Awake
		// -------------------------------------------------------------------------------
		protected override void Awake()
		{
			if (singleton == null) singleton = this;
			base.Awake();
		}
		
		// -------------------------------------------------------------------------------
		// Setup
		// -------------------------------------------------------------------------------
		public void Setup(string _description, float _duration=2)
		{
			Show(_description);
			Invoke(nameof(Close), _duration);
		}
		
		// -------------------------------------------------------------------------------
		// OnDestroy
		// -------------------------------------------------------------------------------
		void OnDestroy()
		{
			CancelInvoke(nameof(Close));
		}
		
		// -------------------------------------------------------------------------------
		
	}

}

// =======================================================================================