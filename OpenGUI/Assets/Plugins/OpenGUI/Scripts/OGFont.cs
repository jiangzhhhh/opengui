using UnityEngine;
using System.Collections;

public static class CharacterInfoExtension {
	public static bool IsSpace(this CharacterInfo self) {
		return self.index == ' ';
	}
}

public class OGFont : MonoBehaviour {
	public Font font;
	public int size = 72;
	public Vector2 atlasSize;

	public void UpdateData () {
		#if UNITY_EDITOR
		atlasSize = new Vector2 ( font.material.mainTexture.width, font.material.mainTexture.height );
		#endif
	}

	public CharacterInfo GetCharacterInfo ( int index ) {
        CharacterInfo info;
        font.GetCharacterInfo((char)index, out info);
        return info;
	}
}
