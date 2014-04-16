/* Generated by JSIL v0.7.8 build 17777. See http://jsil.org/ for more information. */ 
var $asm00 = JSIL.DeclareAssembly("JSILTest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null");

JSIL.SetEntryPoint($asm00, $asm00.TypeRef("JSILTest.Program"), "Main", new JSIL.MethodSignature(null, [$jsilcore.TypeRef("System.Array", [$asm06.TypeRef("System.String")])]));

JSIL.DeclareNamespace("JSILTest");
/* class JSILTest.Program */ 

(function Program$Members () {
  var $, $thisType;
  var $T00 = function () {
    return ($T00 = JSIL.Memoize(System.Array.Of($asm06.System.String))) ();
  };
  var $T01 = function () {
    return ($T01 = JSIL.Memoize($asm00.JSILTest.Game1)) ();
  };
  var $T02 = function () {
    return ($T02 = JSIL.Memoize($asm02.Microsoft.Xna.Framework.Game)) ();
  };
  var $T03 = function () {
    return ($T03 = JSIL.Memoize($asm06.System.IDisposable)) ();
  };
  var $IM00 = function () {
    return ($IM00 = JSIL.Memoize($asm06.System.IDisposable.Dispose)) ();
  };

  function Program_Main (args) {
    var game = new ($T01())();
    try {
      game.Run();
    } finally {
      if (game !== null) {
        $IM00().Call(game, null);
      }
    }
  };

  JSIL.MakeStaticClass("JSILTest.Program", false, [], function ($interfaceBuilder) {
    $ = $interfaceBuilder;

    $.Method({Static:true , Public:false}, "Main", 
      new JSIL.MethodSignature(null, [$jsilcore.TypeRef("System.Array", [$.String])], []), 
      Program_Main
    );

    return function (newThisType) { $thisType = newThisType; }; 
  });

})();

/* class JSILTest.Game1 */ 

(function Game1$Members () {
  var $, $thisType;
  var $T00 = function () {
    return ($T00 = JSIL.Memoize($asm02.Microsoft.Xna.Framework.Game)) ();
  };
  var $T01 = function () {
    return ($T01 = JSIL.Memoize($asm02.Microsoft.Xna.Framework.GraphicsDeviceManager)) ();
  };
  var $T02 = function () {
    return ($T02 = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Content.ContentManager)) ();
  };
  var $T03 = function () {
    return ($T03 = JSIL.Memoize($asm02.Microsoft.Xna.Framework.GameTime)) ();
  };
  var $T04 = function () {
    return ($T04 = JSIL.Memoize($asm04.Microsoft.Xna.Framework.Graphics.GraphicsDevice)) ();
  };
  var $T05 = function () {
    return ($T05 = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Color)) ();
  };
  var $T06 = function () {
    return ($T06 = JSIL.Memoize($asm04.Microsoft.Xna.Framework.Graphics.SpriteBatch)) ();
  };
  var $T07 = function () {
    return ($T07 = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Vector2)) ();
  };
  var $T08 = function () {
    return ($T08 = JSIL.Memoize($asm04.Microsoft.Xna.Framework.Graphics.Texture2D)) ();
  };
  var $T09 = function () {
    return ($T09 = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Input.GamePadButtons)) ();
  };
  var $T0A = function () {
    return ($T0A = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Input.GamePadState)) ();
  };
  var $T0B = function () {
    return ($T0B = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Input.GamePad)) ();
  };
  var $T0C = function () {
    return ($T0C = JSIL.Memoize($asm01.Microsoft.Xna.Framework.PlayerIndex)) ();
  };
  var $T0D = function () {
    return ($T0D = JSIL.Memoize($asm01.Microsoft.Xna.Framework.Input.ButtonState)) ();
  };

  function Game1__ctor () {
    $T00().prototype._ctor.call(this);
    this.graphics = new ($T01())(this);
    this.get_Content().set_RootDirectory("Content");
  };

  function Game1_Draw (gameTime) {
    this.get_GraphicsDevice().InternalClear($T05().get_CornflowerBlue());
    this.spriteBatch.Begin();
    this.spriteBatch.Draw(
      this._sprite, 
      $T07().get_Zero(), 
      $T05().get_White()
    );
    this.spriteBatch.End();
    $T00().prototype.Draw.call(this, gameTime);
  };

  function Game1_Initialize () {
    $T00().prototype.Initialize.call(this);
  };

  function Game1_LoadContent () {
    this.spriteBatch = new ($T06())(this.get_GraphicsDevice());
    this._sprite = this.get_Content().Load$b1($T08())("chickennugents");
  };

  function Game1_UnloadContent () {
  };

  function Game1_Update (gameTime) {
    if ($T0B().GetState($T0C().One).get_Buttons().get_Back() === $T0D().Pressed) {
      this.Exit();
    }
    $T00().prototype.Update.call(this, gameTime);
  };

  JSIL.MakeType({
      BaseType: $asm02.TypeRef("Microsoft.Xna.Framework.Game"), 
      Name: "JSILTest.Game1", 
      IsPublic: true, 
      IsReferenceType: true, 
      MaximumConstructorArguments: 0, 
    }, function ($interfaceBuilder) {
    $ = $interfaceBuilder;

    $.Method({Static:false, Public:true }, ".ctor", 
      new JSIL.MethodSignature(null, [], []), 
      Game1__ctor
    );

    $.Method({Static:false, Public:false, Virtual:true }, "Draw", 
      new JSIL.MethodSignature(null, [$asm02.TypeRef("Microsoft.Xna.Framework.GameTime")], []), 
      Game1_Draw
    );

    $.Method({Static:false, Public:false, Virtual:true }, "Initialize", 
      new JSIL.MethodSignature(null, [], []), 
      Game1_Initialize
    );

    $.Method({Static:false, Public:false, Virtual:true }, "LoadContent", 
      new JSIL.MethodSignature(null, [], []), 
      Game1_LoadContent
    );

    $.Method({Static:false, Public:false, Virtual:true }, "UnloadContent", 
      new JSIL.MethodSignature(null, [], []), 
      Game1_UnloadContent
    );

    $.Method({Static:false, Public:false, Virtual:true }, "Update", 
      new JSIL.MethodSignature(null, [$asm02.TypeRef("Microsoft.Xna.Framework.GameTime")], []), 
      Game1_Update
    );

    $.Field({Static:false, Public:false}, "graphics", $asm02.TypeRef("Microsoft.Xna.Framework.GraphicsDeviceManager")); 
    $.Field({Static:false, Public:false}, "spriteBatch", $asm04.TypeRef("Microsoft.Xna.Framework.Graphics.SpriteBatch")); 
    $.Field({Static:false, Public:false}, "_sprite", $asm04.TypeRef("Microsoft.Xna.Framework.Graphics.Texture2D")); 
    $.ImplementInterfaces(
    );

    return function (newThisType) { $thisType = newThisType; }; 
  });

})();

