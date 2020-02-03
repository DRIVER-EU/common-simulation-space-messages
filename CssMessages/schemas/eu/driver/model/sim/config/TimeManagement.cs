// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace eu.driver.model.sim.config
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class TimeManagement : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""TimeManagement"",""namespace"":""eu.driver.model.sim.config"",""fields"":[{""name"":""state"",""doc"":""State the time is currently in"",""type"":{""type"":""enum"",""name"":""TimeState"",""namespace"":""eu.driver.model.sim.config"",""symbols"":[""Initialisation"",""Started"",""Paused"",""Stopped"",""Reset""]}},{""name"":""tags"",""doc"":""Optional map containing session time specific information: key – unique name of the specific property; value – value of that property"",""default"":null,""type"":[""null"",{""type"":""map"",""values"":""string""}]},{""name"":""timestamp"",""doc"":""Optional UNIX Epoch time in milliseconds marking the time the update was or needs to be performed"",""default"":null,""type"":[""null"",""long""],""logicalType"":""timestamp-millis""},{""name"":""simulationTime"",""doc"":""Optional UNIX Epoch time in milliseconds marking the fictive date and time the session should run with"",""default"":null,""type"":[""null"",""long""],""logicalType"":""timestamp-millis""},{""name"":""simulationSpeed"",""doc"":""Optional speed factor this session wants to run a simulation. The range of this speed factor is [0, infinity)"",""default"":null,""type"":[""null"",""float""]}],""_comment"":""""}");
		/// <summary>
		/// State the time is currently in
		/// </summary>
		private eu.driver.model.sim.config.TimeState _state;
		/// <summary>
		/// Optional map containing session time specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		private IDictionary<string,System.String> _tags;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the update was or needs to be performed
		/// </summary>
		private System.Nullable<long> _timestamp;
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the fictive date and time the session should run with
		/// </summary>
		private System.Nullable<long> _simulationTime;
		/// <summary>
		/// Optional speed factor this session wants to run a simulation. The range of this speed factor is [0, infinity)
		/// </summary>
		private System.Nullable<float> _simulationSpeed;
		public virtual Schema Schema
		{
			get
			{
				return TimeManagement._SCHEMA;
			}
		}
		/// <summary>
		/// State the time is currently in
		/// </summary>
		public eu.driver.model.sim.config.TimeState state
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		/// <summary>
		/// Optional map containing session time specific information: key – unique name of the specific property; value – value of that property
		/// </summary>
		public IDictionary<string,System.String> tags
		{
			get
			{
				return this._tags;
			}
			set
			{
				this._tags = value;
			}
		}
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the time the update was or needs to be performed
		/// </summary>
		public System.Nullable<long> timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				this._timestamp = value;
			}
		}
		/// <summary>
		/// Optional UNIX Epoch time in milliseconds marking the fictive date and time the session should run with
		/// </summary>
		public System.Nullable<long> simulationTime
		{
			get
			{
				return this._simulationTime;
			}
			set
			{
				this._simulationTime = value;
			}
		}
		/// <summary>
		/// Optional speed factor this session wants to run a simulation. The range of this speed factor is [0, infinity)
		/// </summary>
		public System.Nullable<float> simulationSpeed
		{
			get
			{
				return this._simulationSpeed;
			}
			set
			{
				this._simulationSpeed = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this.state;
			case 1: return this.tags;
			case 2: return this.timestamp;
			case 3: return this.simulationTime;
			case 4: return this.simulationSpeed;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this.state = (eu.driver.model.sim.config.TimeState)fieldValue; break;
			case 1: this.tags = (IDictionary<string,System.String>)fieldValue; break;
			case 2: this.timestamp = (System.Nullable<long>)fieldValue; break;
			case 3: this.simulationTime = (System.Nullable<long>)fieldValue; break;
			case 4: this.simulationSpeed = (System.Nullable<float>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}
