using System.Threading.Tasks;

namespace MyPreciousData.Utils
{
  /// <summary>
  /// Provides completed task constants.
  /// </summary>
  public static class TaskConst
  {
    private static readonly Task<bool> InternalBooleanTrue =
      Task.FromResult(true);
    private static readonly Task<int> InternalIntNegativeOne =
      Task.FromResult(-1);

    /// <summary>
    /// A task that has been completed with the value <c>true</c>.
    /// </summary>
    public static Task<bool> BooleanTrue => InternalBooleanTrue;

    /// <summary>
    /// A task that has been completed with the value <c>false</c>.
    /// </summary>
    public static Task<bool> BooleanFalse => TaskConst<bool>.Default;

    /// <summary>
    /// A task that has been completed with the value <c>0</c>.
    /// </summary>
    public static Task<int> Int32Zero => TaskConst<int>.Default;

    /// <summary>
    /// A task that has been completed with the value <c>-1</c>.
    /// </summary>
    public static Task<int> Int32NegativeOne => InternalIntNegativeOne;

    /// <summary>
    /// A <see cref="Task"/> that has been completed.
    /// </summary>
    public static Task Completed => InternalBooleanTrue;

    /// <summary>
    /// A <see cref="Task"/> that will never complete.
    /// </summary>
    public static Task Never => TaskConst<bool>.Never;

    /// <summary>
    /// A task that has been canceled.
    /// </summary>
    public static Task Canceled => TaskConst<bool>.Canceled;
  }

  /// <summary>
  /// Provides completed task constants.
  /// </summary>
  /// <typeparam name="T">The type of the task result.</typeparam>
  public static class TaskConst<T>
  {
    private static readonly Task<T> DefaultValue =
      Task.FromResult(default(T));

    private static readonly Task<T> NeverValue =
      new TaskCompletionSource<T>().Task;

    private static readonly Task<T> CanceledValue =
      CanceledTask();

    private static Task<T> CanceledTask()
    {
      var tcs = new TaskCompletionSource<T>();
      tcs.SetCanceled();
      return tcs.Task;
    }

    /// <summary>
    /// A task that has been completed with the default value of
    /// <typeparamref name="T"/>.
    /// </summary>
    public static Task<T> Default => DefaultValue;

    /// <summary>
    /// A <see cref="Task"/> that will never complete.
    /// </summary>
    public static Task<T> Never => NeverValue;

    /// <summary>
    /// A task that has been canceled.
    /// </summary>
    public static Task<T> Canceled => CanceledValue;
  }
}
