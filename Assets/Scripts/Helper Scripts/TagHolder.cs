using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axis
{
    public const string HORIZONTAL = "Horizontal";
    public const string VERTICAL = "Vertical";
}
public class MouseAxis
{
    public const string MOUSE_X = "Mouse X";
    public const string MOUSE_Y = "Mouse Y";
}

public class AnimTags
{
    public const string ZOOM_IN_ANIM = "ZoomIn";
    public const string ZOOM_OUT_ANIM = "ZoomOut";
    public const string SHOOT_TRIGGER = "Shoot";
    public const string AIM = "Aim";
    public const string PLAYER_WALK = "Player Walk";
    public const string WALK = "Walk";
    public const string RUN = "Run";
    public const string PLAYER_RUN = "Player Run";
    public const string ATTACK = "Attack";
    public const string DEAD = "Dead";
}

public class Tags
{
    public const string LOOK_ROOT = "Look Root";
    public const string ZOOM_CAMERA = "FP Camera";
    public const string CROSSHAIR = "Crosshair";
    public const string PLAYER_TAG = "Player";
    public const string ENEMY_TAG = "Enemy";
}