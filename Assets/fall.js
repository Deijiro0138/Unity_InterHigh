#pragma strict
var ballPrefab: GameObject;
var timer:float;
var fall:int;
function Start() {
    DropBall(5000000+fall); //ボー
    fall=0;
}
function Update(){
    /*timer+=Time.deltaTime;
    if (timer > 25f) {
               fall += 0.0002f;
           } else if (timer > 45f) {
               fall += 0.0002f;
           }*/
    //ri.GetComponent.<Rigidbody2D>().AddForce (Vector3.down * fall);
}
private
function DropBall(count: int) {
    for (var i = 0; i < count; i++) {
        fall+=1;
        var ball = Instantiate(ballPrefab); //ボールのプレハブを読み込み
        ball.transform.position.x = Random.Range(502, 515); //ボールのｘ座標をランダムに設定
        ball.transform.position.y = 400; //ボールのｙ座標を調整
        //ball.transform.eulerAngles.z = Random.Range(-40, 40); //ボールの角度をランダムに設定
        var spriteId: int = Random.Range(0, 5); //ボールの画像をidに合わせて変更
        yield WaitForSeconds(0.6); //次のボールを生成するまで一定時間待つ
    }
}