public static class Constants
{
    public static readonly string ApplicationName = "Assets Racoon";

    // タイトル
    public static readonly string Title = "Initialize assets";

    // フォルダのパス
    public static readonly string FBXFolder = "Assets/FBX/";
    public static readonly string MaterialsFolder = "Assets/Materials/";

    public static readonly string TexturesFolder = "Assets/Textures/";

    // エラーメッセージ
    public static readonly string ErrorTitle = "Error";
    public static readonly string ErrorNoFBXPath = "FBXファイルを選択してください。";

    // ボタンテキスト
    public static readonly string OK = "OK";
    public static readonly string ButtonSelectFBX = "FBXを選択";
    public static readonly string ButtonCancel = "Cancel";
    public static readonly string ButtonNext = "Next";

    // ダイアログメッセージ
    public static readonly string ErrorInvalidFBXPath =
        "Please select both FBX file and Texture folder.";
    public static readonly string ErrorMaterialExtraction = "マテリアルの抽出に失敗しました。";
}
