/*
 * Criado por SharpDevelop.
 * Usuário: Pedro
 * Data: 29/05/2015
 * Hora: 10:46
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Globalization;

namespace JARVIS
{
	/// <summary>
	/// Description of GetVoices.
	/// </summary>
	public static class GetVoices
	{
        /// <summary>
        /// Static method that returns all installed voices by 
        /// the culture.
        /// </summary>
		public static List<string> GetVoicesFromCulture(string culture)
		{
            ///<remarks>
            ///SpeechSynthesizer object.
            ///</remarks>
			SpeechSynthesizer sp = new SpeechSynthesizer();
			List<string> result = new List<string>();
			foreach(InstalledVoice voice in sp.GetInstalledVoices())
			{
				VoiceInfo info = voice.VoiceInfo;
				CultureInfo cul = new CultureInfo(culture);
				string cultura = Convert.ToString(info.Culture);
				if(cultura==culture)
				{
					result.Add(info.Name);
				}
			}
			return result;
		}
	}
}
