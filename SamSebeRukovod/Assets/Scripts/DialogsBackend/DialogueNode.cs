[System.Serializable]
public class DialogueNode {
    public string SpeakerText;
    public DialogueOption[] Options; // null, если просто реплика
}
